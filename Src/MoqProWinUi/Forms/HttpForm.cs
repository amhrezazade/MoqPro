using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoqProWinUi.Forms
{
    public partial class HttpForm : Form
    {
        private HttpListener? _listener;
        private CancellationTokenSource? _cts;


        public HttpForm()
        {
            InitializeComponent();
        }

        private void HttpForm_Load(object sender, EventArgs e)
        {

        }

        private void StartServer()
        {
            _cts = new CancellationTokenSource();
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://localhost:8080/");
            _listener.Start();

            Task.Run(async () =>
            {
                while (!_cts.Token.IsCancellationRequested)
                {
                    try
                    {
                        var context = await _listener.GetContextAsync();

                        string method = context.Request.HttpMethod;
                        string path = context.Request.Url.AbsolutePath;
                        string? body = null;
                        Dictionary<string, string> queryParams = new();

                        if (context.Request.QueryString != null)
                        {
                            foreach (string key in context.Request.QueryString)
                                queryParams[key] = context.Request.QueryString[key];
                        }

                        if (context.Request.HasEntityBody)
                        {
                            using var reader = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding);
                            body = await reader.ReadToEndAsync();
                        }

                        string result = HandleRequest(method, path, body, queryParams);

                        byte[] buffer = Encoding.UTF8.GetBytes(result);
                        context.Response.ContentType = "application/json";
                        context.Response.ContentEncoding = Encoding.UTF8;
                        context.Response.ContentLength64 = buffer.Length;
                        await context.Response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
                        context.Response.Close();
                    }
                    catch (Exception ex)
                    {
                        if (!_cts.Token.IsCancellationRequested)
                            MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }, _cts.Token);
        }

        private void StopServer()
        {
            _cts?.Cancel();
            _listener?.Stop();
            _listener = null;
        }
    }
}

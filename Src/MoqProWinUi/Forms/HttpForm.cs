using MoqProDomain.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoqProWinUi.Forms
{
    public partial class HttpForm : Form
    {
        private HttpListener _listener;
        private CancellationTokenSource _cts;
        private readonly RequestHandlerService _service;
        private readonly string _url;
        public HttpForm(RequestHandlerService requestHandler,string url)
        {
            _url = url;
            _service = requestHandler;
            InitializeComponent();
        }

        private void HttpForm_Load(object sender, EventArgs e)
        {
            StartServer();
            Hide();
        }

        private void StartServer()
        {
            _cts = new CancellationTokenSource();
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://localhost:8080/");
            _listener.Start();

            Task.Run(HandleConnection, _cts.Token);
        }

        private async void HandleConnection()
        {
            while (!_cts.Token.IsCancellationRequested)
            {
                try
                {
                    var context = await _listener.GetContextAsync();

                    string method = context.Request.HttpMethod;
                    string path = context.Request.Url.AbsolutePath;
                    string body = null;
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
        }

        private string HandleRequest(string method, string path, string body, Dictionary<string, string> queryParams)
        {
            // we just need path 
            object result = _service.Handle(path);
            return JsonConvert.SerializeObject(result);
        }

        private void StopServer()
        {
            _cts?.Cancel();
            _listener?.Stop();
            _listener = null;
        }

        private void HttpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();
        }
    }
}

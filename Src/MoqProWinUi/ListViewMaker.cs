using BrightIdeasSoftware;

namespace MoqProWinUi;

public static class ListViewMaker
{

    public static ObjectListView CreateListView<T>(List<T> items)
    {
        // Create an instance of ObjectListView
        var olvSongs = new ObjectListView
        {
            CellEditUseWholeCell = false,
            ShowGroups = false,
            UseCompatibleStateImageBehavior = false,
            View = View.Details
        };

        // get property list of items with reflection:
        Type itemType = typeof(T);
        var properties = itemType.GetProperties();
        foreach (var property in properties)
        {
            var column = new OLVColumn
            {
                AspectName = property.Name,
                Text = property.Name,
                Width = 100 // Default width, can be adjusted later
            };
            // Adjust column width based on property type
            if (property.PropertyType == typeof(string))
            {
                column.Width = 160; // Wider for strings
            }
            else if (property.PropertyType == typeof(int) || property.PropertyType == typeof(double))
            {
                column.TextAlign = HorizontalAlignment.Right; // Right align numbers
                column.Width = 80; // Default width for numbers
            }
            else if (property.PropertyType == typeof(DateTime))
            {
                column.AspectToStringFormat = "{0:d}"; // Format date
                column.Width = 120; // Wider for dates
            }
            else if (property.PropertyType == typeof(Guid))
            {
                column.Width = 200; // Wider for dates
            }
            olvSongs.AllColumns.Add(column);
            olvSongs.Columns.Add(column);
        }

        olvSongs.SetObjects(items);

        return olvSongs;
    }



}

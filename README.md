# Archipelago.Core.GUI
C# library for providing a GUI for my other libraries.

# Usage
```
MainForm form = new MainForm();
form.ConnectClicked += (sender, args) =>
{
Console.WriteLine(args.Host);
Console.WriteLine(args.Slot);
Console.WriteLine(args.Password);
}
```

# Customisation
```
GuiDesignOptions options = new GuiDesignOptions()
{
Title = "My cool form",
BackgroundColor = Color.Blue,
ButtonColor = Color.Red,
ButtonTextColor = Color.Green,
Image = Helpers.LoadImageFromResource("Doggo.png")
}
MainForm form = new MainForm(options);
```

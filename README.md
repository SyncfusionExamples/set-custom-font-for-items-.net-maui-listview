# How to set custom font for items loaded in .NET MAUI ListView (SfListView) ?

The [.NET MAUI ListView (SfListView)](https://www.syncfusion.com/maui-controls/maui-listview) provides the capability to enhance item appearance using custom fonts. This guide outlines the steps to implement custom fonts in SfListView.

**Steps**
1. Add the custom fonts in True Type Font (TTF) format within the Resources’ Fonts folder.
2. Register these fonts in your application by invoking the **ConfigureFonts** method on the **MauiAppBuilder** object. Use the **AddFont** method to specify the font filename and an optional alias.
3. Refer to the font name or alias using the **FontFamily** property within your XAML to apply the fonts.

![Custom fonts in .NET MAUI ListView (SfListView)](https://www.syncfusion.com/uploads/user/kb/maui/maui-2117/maui-2117_img1.png)

Download the complete sample on [GitHub](https://github.com/SyncfusionExamples/set-custom-font-for-items-.net-maui-listview).

**Conclusion**

I hope you enjoyed learning how to set a custom font for items loaded in .NET MAUI ListView.

You can refer to our [.NET MAUI ListView feature tour](https://www.syncfusion.com/maui-controls/maui-listview) page to learn about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/maui/listview/getting-started), and how to quickly get started with configuration specifications. Explore our [.NET MAUI ListView example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView) to understand how to create and manipulate data.

For current customers, check out our components from the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion®, try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to check out our other controls.

Please let us know in the comments section if you have any queries or require clarification. Contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sflistview). We are always happy to assist you!

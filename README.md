# How-to-Choose-Templates-Dynamically-in-.NET-MAUI-Rotator

This demo shows how to dynamically choose templates in the .NET MAUI SfRotator control.

This section explains how to dynamically select different templates for items in the .NET MAUI SfRotator control using the DataTemplateSelector. A custom template selector enables the rotator to display different UI layouts based on the data of each item.

The DataTemplateSelector evaluates each item at runtime and automatically applies the appropriate template according to the defined selection logic. This approach helps create flexible, data-driven, and visually rich user interfaces while keeping the UI implementation clean and maintainable.

In this example, a custom DataTemplateSelector is used to determine whether a rotator item should display a default layout or a specialized layout. The specialized template can include additional UI elements such as overlays, badges, descriptive text, or custom styling, while other items continue to use the standard template.

### Key Highlights

- Dynamically selects templates at runtime.
- Supports multiple item layouts within the same SfRotator.
- Uses DataTemplateSelector for data-driven UI customization.
- Improves maintainability by separating selection logic from UI definitions.
- Enables visually distinct presentations for specific rotator items.

By following the implementation steps, you can easily customize the appearance of individual SfRotator items and create rich user experiences based on your application data.

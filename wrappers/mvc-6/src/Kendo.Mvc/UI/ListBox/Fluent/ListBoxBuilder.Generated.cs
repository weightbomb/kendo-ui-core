using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ListBox
    /// </summary>
    public partial class ListBoxBuilder
        
    {
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public ListBoxBuilder AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// A selector which determines that the target ListBox should be used when items are transferred from and to the current ListBox. The connectWith option defines one-way relationship - if the developer wants a two-way connection, then the connectWith option should be set on both widgets.
        /// </summary>
        /// <param name="value">The value for ConnectWith</param>
        public ListBoxBuilder ConnectWith(string value)
        {
            Container.ConnectWith = value;
            return this;
        }

        /// <summary>
        /// The field of the data item that provides the text content of the list items. The widget will filter the data source based on this field.
        /// </summary>
        /// <param name="value">The value for DataTextField</param>
        public ListBoxBuilder DataTextField(string value)
        {
            Container.DataTextField = value;
            return this;
        }

        /// <summary>
        /// The field of the data item that provides the value of the widget.
        /// </summary>
        /// <param name="value">The value for DataValueField</param>
        public ListBoxBuilder DataValueField(string value)
        {
            Container.DataValueField = value;
            return this;
        }

        /// <summary>
        /// Indicates if the widget items can be draged and droped.
        /// </summary>
        /// <param name="configurator">The configurator for the draggable setting.</param>
        public ListBoxBuilder Draggable(Action<ListBoxDraggableSettingsBuilder> configurator)
        {
            Container.Draggable.Enabled = true;

            Container.Draggable.ListBox = Container;
            configurator(new ListBoxDraggableSettingsBuilder(Container.Draggable));

            return this;
        }

        /// <summary>
        /// Indicates if the widget items can be draged and droped.
        /// </summary>
        public ListBoxBuilder Draggable()
        {
            Container.Draggable.Enabled = true;
            return this;
        }

        /// <summary>
        /// Indicates if the widget items can be draged and droped.
        /// </summary>
        /// <param name="enabled">Enables or disables the draggable option.</param>
        public ListBoxBuilder Draggable(bool enabled)
        {
            Container.Draggable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Array of id strings which determines the ListBox widgets that can drag and drop their items to the current ListBox widget. The dropSources option describes one way relationship, if the developer wants a two way connection then the dropSources option should be set on both widgets.
        /// </summary>
        /// <param name="value">The value for DropSources</param>
        public ListBoxBuilder DropSources(params string[] value)
        {
            Container.DropSources = value;
            return this;
        }

        /// <summary>
        /// Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        /// <param name="value">The value for Navigatable</param>
        public ListBoxBuilder Navigatable(bool value)
        {
            Container.Navigatable = value;
            return this;
        }

        /// <summary>
        /// Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        public ListBoxBuilder Navigatable()
        {
            Container.Navigatable = true;
            return this;
        }

        /// <summary>
        /// Defines the localization texts for the ListBox. Used primarily for localization.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public ListBoxBuilder Messages(Action<ListBoxMessagesSettingsBuilder> configurator)
        {

            Container.Messages.ListBox = Container;
            configurator(new ListBoxMessagesSettingsBuilder(Container.Messages));

            return this;
        }

        /// <summary>
        /// Specifies ListBox item template.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ListBoxBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// Specifies ListBox item template.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ListBoxBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Defines settings for displaying a toolbar for the ListBox widget, which allows a set of predefined actions to be executed. By default, the toolbar isn't shown. Populating the tools array will show the toolbar and the corresponding tools.
        /// </summary>
        /// <param name="configurator">The configurator for the toolbar setting.</param>
        public ListBoxBuilder Toolbar(Action<ListBoxToolbarSettingsBuilder> configurator)
        {

            Container.Toolbar.ListBox = Container;
            configurator(new ListBoxToolbarSettingsBuilder(Container.Toolbar));

            return this;
        }

        /// <summary>
        /// Represents the selectable options.
        /// </summary>
        /// <param name="value">The value for Selectable</param>
        public ListBoxBuilder Selectable(ListBoxSelectable value)
        {
            Container.Selectable = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().ListBox()
        ///       .Name("ListBox")
        ///       .Events(events => events
        ///           .Add("onAdd")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ListBoxBuilder Events(Action<ListBoxEventBuilder> configurator)
        {
            configurator(new ListBoxEventBuilder(Container.Events));
            return this;
        }
        
    }
}

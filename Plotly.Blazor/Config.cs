/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor
{
    /// <summary>
    ///     The Config class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class Config : IEquatable<Config>
    {
        /// <summary>
        ///     Determines whether the graphs are plotted with respect to layout.autosize:true
        ///     and infer its container size.
        /// </summary>
        [JsonPropertyName(@"autosizable")]
        public bool? AutoSizable { get; set;} 

        /// <summary>
        ///     Determines whether or not the plotly logo is displayed on the end of the
        ///     mode bar.
        /// </summary>
        [JsonPropertyName(@"displaylogo")]
        public bool? DisplayLogo { get; set;} 

        /// <summary>
        ///     Determines the mode bar display mode. If <c>true</c>, the mode bar is always
        ///     visible. If <c>false</c>, the mode bar is always hidden. If <c>hover</c>,
        ///     the mode bar is visible while the mouse cursor is on the graph container.
        /// </summary>
        [JsonPropertyName(@"displayModeBar")]
        public Plotly.Blazor.ConfigLib.DisplayModeBarEnum? DisplayModeBar { get; set;} 

        /// <summary>
        ///     Sets the double click interaction mode. Has an effect only in cartesian
        ///     plots. If <c>false</c>, double click is disable. If <c>reset</c>, double
        ///     click resets the axis ranges to their initial values. If <c>autosize</c>,
        ///     double click set the axis ranges to their autorange values. If <c>reset+autosize</c>,
        ///     the odd double clicks resets the axis ranges to their initial values and
        ///     even double clicks set the axis ranges to their autorange values.
        /// </summary>
        [JsonPropertyName(@"doubleClick")]
        public Plotly.Blazor.ConfigLib.DoubleClickEnum? DoubleClick { get; set;} 

        /// <summary>
        ///     Sets the delay for registering a double-click in ms. This is the time interval
        ///     (in ms) between first mousedown and 2nd mouseup to constitute a double-click.
        ///     This setting propagates to all on-subplot double clicks (except for geo
        ///     and mapbox) and on-legend double clicks.
        /// </summary>
        [JsonPropertyName(@"doubleClickDelay")]
        public decimal? DoubleClickDelay { get; set;} 

        /// <summary>
        ///     Determines whether the graph is editable or not. Sets all pieces of <c>edits</c>
        ///     unless a separate <c>edits</c> config item overrides individual parts.
        /// </summary>
        [JsonPropertyName(@"editable")]
        public bool? Editable { get; set;} 

        /// <summary>
        ///     Gets or sets the Edits.
        /// </summary>
        [JsonPropertyName(@"edits")]
        public Plotly.Blazor.ConfigLib.Edits Edits { get; set;} 

        /// <summary>
        ///     Enables moving selections.
        /// </summary>
        [JsonPropertyName(@"editSelection")]
        public bool? EditSelection { get; set;} 

        /// <summary>
        ///     When <c>layout.autosize</c> is turned on, determines whether the graph fills
        ///     the container (the default) or the screen (if set to <c>true</c>).
        /// </summary>
        [JsonPropertyName(@"fillFrame")]
        public bool? FillFrame { get; set;} 

        /// <summary>
        ///     When <c>layout.autosize</c> is turned on, set the frame margins in fraction
        ///     of the graph size.
        /// </summary>
        [JsonPropertyName(@"frameMargins")]
        public decimal? FrameMargins { get; set;} 

        /// <summary>
        ///     Set global transform to be applied to all traces with no specification needed
        /// </summary>
        [JsonPropertyName(@"globalTransforms")]
        public object GlobalTransforms { get; set;} 

        /// <summary>
        ///     Sets the text appearing in the <c>showLink</c> link.
        /// </summary>
        [JsonPropertyName(@"linkText")]
        public string LinkText { get; set;} 

        /// <summary>
        ///     Which localization should we use? Should be a string like <c>en</c> or <c>en-US</c>.
        /// </summary>
        [JsonPropertyName(@"locale")]
        public string Locale { get; set;} 

        /// <summary>
        ///     Localization definitions Locales can be provided either here (specific to
        ///     one chart) or globally by registering them as modules. Should be an object
        ///     of objects {locale: {dictionary: {...}, format: {...}}} {   da: {      
        ///     dictionary: {&#39;Reset axes&#39;: &#39;Nulstil aksler&#39;, ...},     
        ///      format: {months: [...], shortMonths: [...]}   },   ... } All parts are
        ///     optional. When looking for translation or format fields, we look first for
        ///     an exact match in a config locale, then in a registered module. If those
        ///     fail, we strip off any regionalization (<c>en-US</c> -&gt; <c>en</c>) and
        ///     try each (config, registry) again. The final fallback for translation is
        ///     untranslated (which is US English) and for formats is the base English (the
        ///     only consequence being the last fallback date format %x is DD/MM/YYYY instead
        ///     of MM/DD/YYYY). Currently <c>grouping</c> and <c>currency</c> are ignored
        ///     for our automatic number formatting, but can be used in custom formats.
        /// </summary>
        [JsonPropertyName(@"locales")]
        public object Locales { get; set;} 

        /// <summary>
        ///     Turn all console logging on or off (errors will be thrown) This should ONLY
        ///     be set via Plotly.setPlotConfig Available levels: 0: no logs 1: warnings
        ///     and errors, but not informational messages 2: verbose logs
        /// </summary>
        [JsonPropertyName(@"logging")]
        public int? Logging { get; set;} 

        /// <summary>
        ///     Mapbox access token (required to plot mapbox trace types) If using an Mapbox
        ///     Atlas server, set this option to &#39;&#39; so that plotly.js won&#39;t
        ///     attempt to authenticate to the public Mapbox server.
        /// </summary>
        [JsonPropertyName(@"mapboxAccessToken")]
        public string MapboxAccessToken { get; set;} 

        /// <summary>
        ///     Define fully custom mode bar buttons as nested array, where the outer arrays
        ///     represents button groups, and the inner arrays have buttons config objects
        ///     or names of default buttons See ./components/modebar/buttons.js for more
        ///     info.
        /// </summary>
        [JsonPropertyName(@"modeBarButtons")]
        public object ModeBarButtons { get; set;} 

        /// <summary>
        ///     Add mode bar button using config objects See ./components/modebar/buttons.js
        ///     for list of arguments. To enable predefined modebar buttons e.g. shape drawing,
        ///     hover and spikelines, simply provide their string name(s). This could include:
        ///     <c>v1hovermode</c>, <c>hoverclosest</c>, <c>hovercompare</c>, <c>togglehover</c>,
        ///     <c>togglespikelines</c>, <c>drawline</c>, <c>drawopenpath</c>, <c>drawclosedpath</c>,
        ///     <c>drawcircle</c>, <c>drawrect</c> and <c>eraseshape</c>. Please note that
        ///     these predefined buttons will only be shown if they are compatible with
        ///     all trace types used in a graph.
        /// </summary>
        [JsonPropertyName(@"modeBarButtonsToAdd")]
        public object ModeBarButtonsToAdd { get; set;} 

        /// <summary>
        ///     Remove mode bar buttons by name. See ./components/modebar/buttons.js for
        ///     the list of names.
        /// </summary>
        [JsonPropertyName(@"modeBarButtonsToRemove")]
        public object ModeBarButtonsToRemove { get; set;} 

        /// <summary>
        ///     Set on-graph logging (notifier) level This should ONLY be set via Plotly.setPlotConfig
        ///     Available levels: 0: no on-graph logs 1: warnings and errors, but not informational
        ///     messages 2: verbose logs
        /// </summary>
        [JsonPropertyName(@"notifyOnLogging")]
        public int? NotifyOnLogging { get; set;} 

        /// <summary>
        ///     Set the pixel ratio during WebGL image export. This config option was formerly
        ///     named <c>plot3dPixelRatio</c> which is now deprecated.
        /// </summary>
        [JsonPropertyName(@"plotGlPixelRatio")]
        public decimal? PlotGlPixelRatio { get; set;} 

        /// <summary>
        ///     When set it determines base URL for the &#39;Edit in Chart Studio&#39; <c>showEditInChartStudio</c>/<c>showSendToCloud</c>
        ///     mode bar button and the showLink/sendData on-graph link. To enable sending
        ///     your data to Chart Studio Cloud, you need to set both <c>plotlyServerURL</c>
        ///     to <c>https://chart-studio.plotly.com</c> and also set <c>showSendToCloud</c>
        ///     to true.
        /// </summary>
        [JsonPropertyName(@"plotlyServerURL")]
        public string PlotlyServerUrl { get; set;} 

        /// <summary>
        ///     Sets the length of the undo/redo queue.
        /// </summary>
        [JsonPropertyName(@"queueLength")]
        public int? QueueLength { get; set;} 

        /// <summary>
        ///     Determines whether to change the layout size when window is resized. In
        ///     v3, this option will be removed and will always be true.
        /// </summary>
        [JsonPropertyName(@"responsive")]
        public bool? Responsive { get; set;} 

        /// <summary>
        ///     Determines whether mouse wheel or two-finger scroll zooms is enable. Turned
        ///     on by default for gl3d, geo and mapbox subplots (as these subplot types
        ///     do not have zoombox via pan), but turned off by default for cartesian subplots.
        ///     Set <c>scrollZoom</c> to <c>false</c> to disable scrolling for all subplots.
        /// </summary>
        [JsonPropertyName(@"scrollZoom")]
        public Plotly.Blazor.ConfigLib.ScrollZoomFlag? ScrollZoom { get; set;} 

        /// <summary>
        ///     If <c>showLink</c> is true, does it contain data just link to a Chart Studio
        ///     Cloud file?
        /// </summary>
        [JsonPropertyName(@"sendData")]
        public bool? SendData { get; set;} 

        /// <summary>
        ///     Set function to add the background color (i.e. <c>layout.paper_color</c>)
        ///     to a different container. This function take the graph div as first argument
        ///     and the current background color as second argument. Alternatively, set
        ///     to string <c>opaque</c> to ensure there is white behind it.
        /// </summary>
        [JsonPropertyName(@"setBackground")]
        public object SetBackground { get; set;} 

        /// <summary>
        ///     Set to <c>false</c> to omit cartesian axis pan/zoom drag handles.
        /// </summary>
        [JsonPropertyName(@"showAxisDragHandles")]
        public bool? ShowAxisDragHandles { get; set;} 

        /// <summary>
        ///     Set to <c>false</c> to omit direct range entry at the pan/zoom drag points,
        ///     note that <c>showAxisDragHandles</c> must be enabled to have an effect.
        /// </summary>
        [JsonPropertyName(@"showAxisRangeEntryBoxes")]
        public bool? ShowAxisRangeEntryBoxes { get; set;} 

        /// <summary>
        ///     Same as <c>showSendToCloud</c>, but use a pencil icon instead of a floppy-disk.
        ///     Note that if both <c>showSendToCloud</c> and <c>showEditInChartStudio</c>
        ///     are turned, only <c>showEditInChartStudio</c> will be honored.
        /// </summary>
        [JsonPropertyName(@"showEditInChartStudio")]
        public bool? ShowEditInChartStudio { get; set;} 

        /// <summary>
        ///     Determines whether a link to Chart Studio Cloud is displayed at the bottom
        ///     right corner of resulting graphs. Use with <c>sendData</c> and <c>linkText</c>.
        /// </summary>
        [JsonPropertyName(@"showLink")]
        public bool? ShowLink { get; set;} 

        /// <summary>
        ///     Should we include a ModeBar button, labeled &quot;Edit in Chart Studio&quot;,
        ///     that sends this chart to chart-studio.plotly.com (formerly plot.ly) or another
        ///     plotly server as specified by <c>plotlyServerURL</c> for editing, export,
        ///     etc? Prior to version 1.43.0 this button was included by default, now it
        ///     is opt-in using this flag. Note that this button can (depending on <c>plotlyServerURL</c>
        ///     being set) send your data to an external server. However that server does
        ///     not persist your data until you arrive at the Chart Studio and explicitly
        ///     click <c>Save</c>.
        /// </summary>
        [JsonPropertyName(@"showSendToCloud")]
        public bool? ShowSendToCloud { get; set;} 

        /// <summary>
        ///     Adds a source-displaying function to show sources on the resulting graphs.
        /// </summary>
        [JsonPropertyName(@"showSources")]
        public object ShowSources { get; set;} 

        /// <summary>
        ///     Determines whether or not tips are shown while interacting with the resulting
        ///     graphs.
        /// </summary>
        [JsonPropertyName(@"showTips")]
        public bool? ShowTips { get; set;} 

        /// <summary>
        ///     Determines whether the graphs are interactive or not. If <c>false</c>, no
        ///     interactivity, for export or image generation.
        /// </summary>
        [JsonPropertyName(@"staticPlot")]
        public bool? StaticPlot { get; set;} 

        /// <summary>
        ///     Statically override options for toImage modebar button allowed keys are
        ///     format, filename, width, height, scale see ../components/modebar/buttons.js
        /// </summary>
        [JsonPropertyName(@"toImageButtonOptions")]
        public object ToImageButtonOptions { get; set;} 

        /// <summary>
        ///     Set the URL to topojson used in geo charts. By default, the topojson files
        ///     are fetched from cdn.plot.ly. For example, set this option to: &lt;path-to-plotly.js&gt;/dist/topojson/
        ///     to render geographical feature using the topojson files that ship with the
        ///     plotly.js module.
        /// </summary>
        [JsonPropertyName(@"topojsonURL")]
        public string TopoJsonUrl { get; set;} 

        /// <summary>
        ///     Determines whether math should be typeset or not, when MathJax (either v2
        ///     or v3) is present on the page.
        /// </summary>
        [JsonPropertyName(@"typesetMath")]
        public bool? TypesetMath { get; set;} 

        /// <summary>
        ///     watermark the images with the company&#39;s logo
        /// </summary>
        [JsonPropertyName(@"watermark")]
        public bool? Watermark { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Config other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Config other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AutoSizable == other.AutoSizable ||
                    AutoSizable != null &&
                    AutoSizable.Equals(other.AutoSizable)
                ) && 
                (
                    DisplayLogo == other.DisplayLogo ||
                    DisplayLogo != null &&
                    DisplayLogo.Equals(other.DisplayLogo)
                ) && 
                (
                    DisplayModeBar == other.DisplayModeBar ||
                    DisplayModeBar != null &&
                    DisplayModeBar.Equals(other.DisplayModeBar)
                ) && 
                (
                    DoubleClick == other.DoubleClick ||
                    DoubleClick != null &&
                    DoubleClick.Equals(other.DoubleClick)
                ) && 
                (
                    DoubleClickDelay == other.DoubleClickDelay ||
                    DoubleClickDelay != null &&
                    DoubleClickDelay.Equals(other.DoubleClickDelay)
                ) && 
                (
                    Editable == other.Editable ||
                    Editable != null &&
                    Editable.Equals(other.Editable)
                ) && 
                (
                    Edits == other.Edits ||
                    Edits != null &&
                    Edits.Equals(other.Edits)
                ) && 
                (
                    EditSelection == other.EditSelection ||
                    EditSelection != null &&
                    EditSelection.Equals(other.EditSelection)
                ) && 
                (
                    FillFrame == other.FillFrame ||
                    FillFrame != null &&
                    FillFrame.Equals(other.FillFrame)
                ) && 
                (
                    FrameMargins == other.FrameMargins ||
                    FrameMargins != null &&
                    FrameMargins.Equals(other.FrameMargins)
                ) && 
                (
                    GlobalTransforms == other.GlobalTransforms ||
                    GlobalTransforms != null &&
                    GlobalTransforms.Equals(other.GlobalTransforms)
                ) && 
                (
                    LinkText == other.LinkText ||
                    LinkText != null &&
                    LinkText.Equals(other.LinkText)
                ) && 
                (
                    Locale == other.Locale ||
                    Locale != null &&
                    Locale.Equals(other.Locale)
                ) && 
                (
                    Locales == other.Locales ||
                    Locales != null &&
                    Locales.Equals(other.Locales)
                ) && 
                (
                    Logging == other.Logging ||
                    Logging != null &&
                    Logging.Equals(other.Logging)
                ) && 
                (
                    MapboxAccessToken == other.MapboxAccessToken ||
                    MapboxAccessToken != null &&
                    MapboxAccessToken.Equals(other.MapboxAccessToken)
                ) && 
                (
                    ModeBarButtons == other.ModeBarButtons ||
                    ModeBarButtons != null &&
                    ModeBarButtons.Equals(other.ModeBarButtons)
                ) && 
                (
                    ModeBarButtonsToAdd == other.ModeBarButtonsToAdd ||
                    ModeBarButtonsToAdd != null &&
                    ModeBarButtonsToAdd.Equals(other.ModeBarButtonsToAdd)
                ) && 
                (
                    ModeBarButtonsToRemove == other.ModeBarButtonsToRemove ||
                    ModeBarButtonsToRemove != null &&
                    ModeBarButtonsToRemove.Equals(other.ModeBarButtonsToRemove)
                ) && 
                (
                    NotifyOnLogging == other.NotifyOnLogging ||
                    NotifyOnLogging != null &&
                    NotifyOnLogging.Equals(other.NotifyOnLogging)
                ) && 
                (
                    PlotGlPixelRatio == other.PlotGlPixelRatio ||
                    PlotGlPixelRatio != null &&
                    PlotGlPixelRatio.Equals(other.PlotGlPixelRatio)
                ) && 
                (
                    PlotlyServerUrl == other.PlotlyServerUrl ||
                    PlotlyServerUrl != null &&
                    PlotlyServerUrl.Equals(other.PlotlyServerUrl)
                ) && 
                (
                    QueueLength == other.QueueLength ||
                    QueueLength != null &&
                    QueueLength.Equals(other.QueueLength)
                ) && 
                (
                    Responsive == other.Responsive ||
                    Responsive != null &&
                    Responsive.Equals(other.Responsive)
                ) && 
                (
                    ScrollZoom == other.ScrollZoom ||
                    ScrollZoom != null &&
                    ScrollZoom.Equals(other.ScrollZoom)
                ) && 
                (
                    SendData == other.SendData ||
                    SendData != null &&
                    SendData.Equals(other.SendData)
                ) && 
                (
                    SetBackground == other.SetBackground ||
                    SetBackground != null &&
                    SetBackground.Equals(other.SetBackground)
                ) && 
                (
                    ShowAxisDragHandles == other.ShowAxisDragHandles ||
                    ShowAxisDragHandles != null &&
                    ShowAxisDragHandles.Equals(other.ShowAxisDragHandles)
                ) && 
                (
                    ShowAxisRangeEntryBoxes == other.ShowAxisRangeEntryBoxes ||
                    ShowAxisRangeEntryBoxes != null &&
                    ShowAxisRangeEntryBoxes.Equals(other.ShowAxisRangeEntryBoxes)
                ) && 
                (
                    ShowEditInChartStudio == other.ShowEditInChartStudio ||
                    ShowEditInChartStudio != null &&
                    ShowEditInChartStudio.Equals(other.ShowEditInChartStudio)
                ) && 
                (
                    ShowLink == other.ShowLink ||
                    ShowLink != null &&
                    ShowLink.Equals(other.ShowLink)
                ) && 
                (
                    ShowSendToCloud == other.ShowSendToCloud ||
                    ShowSendToCloud != null &&
                    ShowSendToCloud.Equals(other.ShowSendToCloud)
                ) && 
                (
                    ShowSources == other.ShowSources ||
                    ShowSources != null &&
                    ShowSources.Equals(other.ShowSources)
                ) && 
                (
                    ShowTips == other.ShowTips ||
                    ShowTips != null &&
                    ShowTips.Equals(other.ShowTips)
                ) && 
                (
                    StaticPlot == other.StaticPlot ||
                    StaticPlot != null &&
                    StaticPlot.Equals(other.StaticPlot)
                ) && 
                (
                    ToImageButtonOptions == other.ToImageButtonOptions ||
                    ToImageButtonOptions != null &&
                    ToImageButtonOptions.Equals(other.ToImageButtonOptions)
                ) && 
                (
                    TopoJsonUrl == other.TopoJsonUrl ||
                    TopoJsonUrl != null &&
                    TopoJsonUrl.Equals(other.TopoJsonUrl)
                ) && 
                (
                    TypesetMath == other.TypesetMath ||
                    TypesetMath != null &&
                    TypesetMath.Equals(other.TypesetMath)
                ) && 
                (
                    Watermark == other.Watermark ||
                    Watermark != null &&
                    Watermark.Equals(other.Watermark)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (AutoSizable != null) hashCode = hashCode * 59 + AutoSizable.GetHashCode();
                if (DisplayLogo != null) hashCode = hashCode * 59 + DisplayLogo.GetHashCode();
                if (DisplayModeBar != null) hashCode = hashCode * 59 + DisplayModeBar.GetHashCode();
                if (DoubleClick != null) hashCode = hashCode * 59 + DoubleClick.GetHashCode();
                if (DoubleClickDelay != null) hashCode = hashCode * 59 + DoubleClickDelay.GetHashCode();
                if (Editable != null) hashCode = hashCode * 59 + Editable.GetHashCode();
                if (Edits != null) hashCode = hashCode * 59 + Edits.GetHashCode();
                if (EditSelection != null) hashCode = hashCode * 59 + EditSelection.GetHashCode();
                if (FillFrame != null) hashCode = hashCode * 59 + FillFrame.GetHashCode();
                if (FrameMargins != null) hashCode = hashCode * 59 + FrameMargins.GetHashCode();
                if (GlobalTransforms != null) hashCode = hashCode * 59 + GlobalTransforms.GetHashCode();
                if (LinkText != null) hashCode = hashCode * 59 + LinkText.GetHashCode();
                if (Locale != null) hashCode = hashCode * 59 + Locale.GetHashCode();
                if (Locales != null) hashCode = hashCode * 59 + Locales.GetHashCode();
                if (Logging != null) hashCode = hashCode * 59 + Logging.GetHashCode();
                if (MapboxAccessToken != null) hashCode = hashCode * 59 + MapboxAccessToken.GetHashCode();
                if (ModeBarButtons != null) hashCode = hashCode * 59 + ModeBarButtons.GetHashCode();
                if (ModeBarButtonsToAdd != null) hashCode = hashCode * 59 + ModeBarButtonsToAdd.GetHashCode();
                if (ModeBarButtonsToRemove != null) hashCode = hashCode * 59 + ModeBarButtonsToRemove.GetHashCode();
                if (NotifyOnLogging != null) hashCode = hashCode * 59 + NotifyOnLogging.GetHashCode();
                if (PlotGlPixelRatio != null) hashCode = hashCode * 59 + PlotGlPixelRatio.GetHashCode();
                if (PlotlyServerUrl != null) hashCode = hashCode * 59 + PlotlyServerUrl.GetHashCode();
                if (QueueLength != null) hashCode = hashCode * 59 + QueueLength.GetHashCode();
                if (Responsive != null) hashCode = hashCode * 59 + Responsive.GetHashCode();
                if (ScrollZoom != null) hashCode = hashCode * 59 + ScrollZoom.GetHashCode();
                if (SendData != null) hashCode = hashCode * 59 + SendData.GetHashCode();
                if (SetBackground != null) hashCode = hashCode * 59 + SetBackground.GetHashCode();
                if (ShowAxisDragHandles != null) hashCode = hashCode * 59 + ShowAxisDragHandles.GetHashCode();
                if (ShowAxisRangeEntryBoxes != null) hashCode = hashCode * 59 + ShowAxisRangeEntryBoxes.GetHashCode();
                if (ShowEditInChartStudio != null) hashCode = hashCode * 59 + ShowEditInChartStudio.GetHashCode();
                if (ShowLink != null) hashCode = hashCode * 59 + ShowLink.GetHashCode();
                if (ShowSendToCloud != null) hashCode = hashCode * 59 + ShowSendToCloud.GetHashCode();
                if (ShowSources != null) hashCode = hashCode * 59 + ShowSources.GetHashCode();
                if (ShowTips != null) hashCode = hashCode * 59 + ShowTips.GetHashCode();
                if (StaticPlot != null) hashCode = hashCode * 59 + StaticPlot.GetHashCode();
                if (ToImageButtonOptions != null) hashCode = hashCode * 59 + ToImageButtonOptions.GetHashCode();
                if (TopoJsonUrl != null) hashCode = hashCode * 59 + TopoJsonUrl.GetHashCode();
                if (TypesetMath != null) hashCode = hashCode * 59 + TypesetMath.GetHashCode();
                if (Watermark != null) hashCode = hashCode * 59 + Watermark.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Config and the right Config.
        /// </summary>
        /// <param name="left">Left Config.</param>
        /// <param name="right">Right Config.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Config left, Config right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Config and the right Config.
        /// </summary>
        /// <param name="left">Left Config.</param>
        /// <param name="right">Right Config.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Config left, Config right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Config</returns>
        public Config DeepClone()
        {
            return this.Copy();
        }
    }
}
<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134076006/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E444)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CheckboxEnumPropertyEditor.cs](./CS/Q183035Sample.Module.Web/CheckboxEnumPropertyEditor.cs)
* [RadioButtonEnumPropertyEditor.cs](./CS/Q183035Sample.Module.Web/RadioButtonEnumPropertyEditor.cs)
* [SampleObject.cs](./CS/Q183035Sample.Module/SampleObject.cs)
<!-- default file list end -->
# OBSOLETE - How to represent a enumeration property via radio buttons or check boxes on the Web


<p><strong>==========================================================</strong><br /><strong>This example is now obsolete. Refer to the <a href="https://www.devexpress.com/Support/Center/p/E689">How to represent an enumeration property via a drop-down box with check boxes</a> one instead.</strong><br /><strong>==========================================================</strong><br /><br />This example demonstrates how to implement property editors using our ASPxCheckBox and ASPxRadioButton controls to manage simple enumeration and flags properties:</p>


```cs
<br>
    [Flags]<br>
    public enum ComboboxEnum { None = 0, Value1 = 1, Value2 = 2 };<br>
    public enum RadioButtonEnum { Value1, Value2 };<br>
<br>
    [DefaultClassOptions]<br>
    public class SampleObject : BaseObject {<br>
        public SampleObject(Session session)<br>
            : base(session) {<br>
        }<br>
        private ComboboxEnum _comboboxEnumProperty;<br>
        public ComboboxEnum ComboboxEnumProperty {<br>
            get { return _comboboxEnumProperty; }<br>
            set { SetPropertyValue("ComboboxEnumProperty", ref _comboboxEnumProperty, value); }<br>
        }<br>
        private RadioButtonEnum _radioButtonEnumProperty;<br>
        public RadioButtonEnum RadioButtonEnumProperty {<br>
            get { return _radioButtonEnumProperty; }<br>
            set { SetPropertyValue("RadioButtonEnumProperty", ref _radioButtonEnumProperty, value); }<br>
        }<br>
    }<br>

```


<p><strong>See Also:</strong><br /> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2794">Display a Property Via the Required Editor</a><br /> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2612">Implement Custom Detail View Item</a><br /> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2678">How to: Implement a Property Editor for a Web Site</a><br /> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2679">How to: Implement a Property Editor for Windows Applications</a><br /><a href="https://www.devexpress.com/Support/Center/p/E2309">How to bind a control in EditForm template to XPObject enumerable field</a></p>

<br/>



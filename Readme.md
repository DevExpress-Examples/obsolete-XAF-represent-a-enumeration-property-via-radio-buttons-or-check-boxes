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



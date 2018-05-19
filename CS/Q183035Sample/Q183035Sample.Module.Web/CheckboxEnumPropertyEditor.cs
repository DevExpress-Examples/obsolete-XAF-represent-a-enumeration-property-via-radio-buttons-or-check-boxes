using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.Web.Editors;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.Web.ASPxEditors;

namespace Q183035Sample.Module.Web {
    [DevExpress.ExpressApp.Editors.PropertyEditor(typeof(Enum), false)]
    public class CheckboxEnumPropertyEditor : WebPropertyEditor {
        private EnumDescriptor enumDescriptor;
        private Dictionary<ASPxCheckBox, int> controlsHash = new Dictionary<ASPxCheckBox, int>();

        public CheckboxEnumPropertyEditor(Type objectType, IModelMemberViewItem info)
            : base(objectType, info) {
            this.enumDescriptor = new EnumDescriptor(MemberInfo.MemberType);
        }

        protected override WebControl CreateEditModeControlCore() {
            Panel placeHolder = new Panel();
            controlsHash.Clear();
            foreach (object enumValue in enumDescriptor.Values) {
                if ((int)enumValue != 0) {
                    ASPxCheckBox checkBox = new DevExpress.Web.ASPxEditors.ASPxCheckBox();
                    controlsHash.Add(checkBox, (int)enumValue);
                    checkBox.Text = enumDescriptor.GetCaption(enumValue);
                    checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                    placeHolder.Controls.Add(checkBox);
                }
            }
            return placeHolder;
        }

        void checkBox_CheckedChanged(object sender, EventArgs e) {
            EditValueChangedHandler(sender, e);
        }
        protected override string GetPropertyDisplayValue() {
            return enumDescriptor.GetCaption(PropertyValue);
        }
        protected override void ReadEditModeValueCore() {
            object value = PropertyValue;
            if (value != null) {
                foreach (ASPxCheckBox checkBox in Editor.Controls) {
                    int currentValue = controlsHash[checkBox];
                    checkBox.Checked = ((int)value & currentValue) != 0;
                }
            }
        }

        protected override object GetControlValueCore() {
            object result = 0;
            foreach (ASPxCheckBox checkBox in Editor.Controls) {
                if (checkBox.Checked) {
                    result = (int)result | controlsHash[checkBox];
                }
            }
            return result;
        }
        public override void BreakLinksToControl(bool unwireEventsOnly) {
            if (Editor != null) {
                foreach (ASPxCheckBox checkBox in Editor.Controls) {
                    checkBox.CheckedChanged -= new EventHandler(checkBox_CheckedChanged);
                }
                if (!unwireEventsOnly) {
                    controlsHash.Clear();
                }
            }
            base.BreakLinksToControl(unwireEventsOnly);
        }
        protected override void SetImmediatePostDataScript(string script) {
            foreach (ASPxCheckBox checkBox in controlsHash.Keys) {
                checkBox.ClientSideEvents.CheckedChanged = script;
            }
        }
        public new Panel Editor {
            get { return (Panel)base.Editor; }
        }
    }
}

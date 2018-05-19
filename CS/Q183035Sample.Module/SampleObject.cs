using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace Q183035Sample.Module {
    [Flags]
    public enum ComboboxEnum { None = 0, Value1 = 1, Value2 = 2 };
    public enum RadioButtonEnum { Value1, Value2 };

    [DefaultClassOptions]
    public class SampleObject : BaseObject {
        public SampleObject(Session session)
            : base(session) {
        }
        private ComboboxEnum _comboboxEnumProperty;
        public ComboboxEnum ComboboxEnumProperty {
            get { return _comboboxEnumProperty; }
            set { SetPropertyValue("ComboboxEnumProperty", ref _comboboxEnumProperty, value); }
        }
        private RadioButtonEnum _radioButtonEnumProperty;
        public RadioButtonEnum RadioButtonEnumProperty {
            get { return _radioButtonEnumProperty; }
            set { SetPropertyValue("RadioButtonEnumProperty", ref _radioButtonEnumProperty, value); }
        }
    }
}

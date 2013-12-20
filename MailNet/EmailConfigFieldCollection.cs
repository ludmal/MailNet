using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace XWT.Mail {
    //public class CustomScriptCollection : ConfigurationElementCollection {
    //    public CustomScriptCollection() {
    //        CustomScript myElement = (CustomScript)CreateNewElement();
    //        Add(myElement);
    //    }

    //    public void Add(CustomScript customElement) {
    //        BaseAdd(customElement);
    //    }

    //    protected override void BaseAdd(ConfigurationElement element) {
    //        base.BaseAdd(element, false);
    //    }

    //    public override ConfigurationElementCollectionType CollectionType {
    //        get {
    //            return ConfigurationElementCollectionType.AddRemoveClearMap;
    //        }
    //    }

    //    protected override ConfigurationElement CreateNewElement() {
    //        return new CustomScript();
    //    }

    //    protected override object GetElementKey(ConfigurationElement element) {
    //        return ((CustomScript)element).ID;
    //    }

    //    public CustomScript this[int Index] {
    //        get {
    //            return (CustomScript)BaseGet(Index);
    //        }
    //        set {
    //            if (BaseGet(Index) != null) {
    //                BaseRemoveAt(Index);
    //            }
    //            BaseAdd(Index, value);
    //        }
    //    }

    //    new public CustomScript this[string Name] {
    //        get {
    //            return (CustomScript)BaseGet(Name);
    //        }
    //    }

    //    public int indexof(CustomScript element) {
    //        return BaseIndexOf(element);
    //    }

    //    public void Remove(CustomScript url) {
    //        if (BaseIndexOf(url) >= 0)
    //            BaseRemove(url.ID);
    //    }

    //    public void RemoveAt(int index) {
    //        BaseRemoveAt(index);
    //    }

    //    public void Remove(string name) {
    //        BaseRemove(name);
    //    }

    //    public void Clear() {
    //        BaseClear();
    //    }

    //}
}

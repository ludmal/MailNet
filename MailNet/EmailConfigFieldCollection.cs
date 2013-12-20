#region License
/*
 **************************************************************
 *  Author: Ludmal de silva, 2010
 *          http://www.ludmal.com/
 *          twitter: @ludmal
 * 
 * Created: 12/11/2010
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 **************************************************************  
*/
#endregion

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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using OpenAC.Net.Core;
using OpenAC.Net.Core.Extensions;
using OpenAC.Net.Sat.Demo.Commom;

namespace OpenAC.Net.Sat.Demo
{
    public static class UIExtensions
    {
        public static void LoadXml(this WebBrowser browser, string xml)
        {
            if (xml == null)
                return;

            var path = Path.GetTempPath();
            var fileName = Guid.NewGuid() + ".xml";
            var fullFileName = Path.Combine(path, fileName);
            var xmlDoc = new XmlDocument();
            if (File.Exists(xml))
                xmlDoc.Load(xml);
            else
                xmlDoc.LoadXml(xml);
            xmlDoc.Save(fullFileName);
            browser.Navigate(fullFileName);
        }

        public static void EnumDataSource<T>(this ComboBox cmb) where T : struct
        {
            cmb.DataSource = (from T value in Enum.GetValues(typeof(T)) select new ItemData<T>(value)).ToArray();
        }

        public static void EnumDataSource<T>(this ComboBox cmb, T valorPadrao) where T : struct
        {
            var list = (from T value in Enum.GetValues(typeof(T)) select new ItemData<T>(value.ToString(), value)).ToArray();
            cmb.DataSource = list;
            cmb.SelectedItem = list.SingleOrDefault(x => x.Content.Equals(valorPadrao));
        }

        public static void SetDataSource<T>(this ComboBox cmb, T[] valores)
        {
            if (valores.IsNullOrEmpty()) return;

            var list = (from T value in valores select new ItemData<T>(value.ToString(), value)).ToArray();
            cmb.DataSource = list;
            cmb.SelectedItem = list.First();
        }

        public static T GetSelectedValue<T>(this ComboBox cmb)
        {
            return ((ItemData<T>)cmb.SelectedItem).Content;
        }

        public static void SetSelectedValue<T>(this ComboBox cmb, T valor)
        {
            var dataSource = (ItemData<T>[])cmb.DataSource;
            cmb.SelectedItem = dataSource.SingleOrDefault(x => x.Content.Equals(valor));
        }

        public static void HideTabHeaders(this TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;

            tabControl.SelectedTab = tabControl.TabPages[0];
        }
    }
}
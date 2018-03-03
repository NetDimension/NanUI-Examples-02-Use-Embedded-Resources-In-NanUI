using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedHtmlResources
{
	using Chromium.Remote;
	using Chromium.WebBrowser;
	using NetDimension.NanUI;

	public partial class Form1 : WinFormium
	{
		public Form1() 
			: base("http://my.resource.local/index.html")
		{
			InitializeComponent();
		}
	}


}

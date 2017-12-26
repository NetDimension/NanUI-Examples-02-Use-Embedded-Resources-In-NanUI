using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedHtmlResources
{
	using NetDimension.NanUI;

	static class Program
	{

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//指定CEF架构和文件目录结构，并初始化CEF
			if (Bootstrap.Load(PlatformArch.Auto, System.IO.Path.Combine(Application.StartupPath, "fx"), System.IO.Path.Combine(Application.StartupPath, "fx\\Resources"), System.IO.Path.Combine(Application.StartupPath, "fx\\Resources\\locales")))
			{
				//注册嵌入资源，并为指定资源指定一个假的域名my.resource.local
				Bootstrap.RegisterAssemblyResources(System.Reflection.Assembly.GetExecutingAssembly(), "my.resource.local");

				Application.Run(new Form1());
			}

		}
	}
}

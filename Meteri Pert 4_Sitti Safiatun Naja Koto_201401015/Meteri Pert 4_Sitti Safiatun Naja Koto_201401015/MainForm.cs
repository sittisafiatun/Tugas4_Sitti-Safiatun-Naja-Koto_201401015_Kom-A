﻿/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 3/2/2022
 * Time: 2:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Meteri_Pert_4_Sitti_Safiatun_Naja_Koto_201401015
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Hello World " + this.textBox1.Text);
		}
	}
}


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Security.Cryptography;
using System.Reflection;
using System.Security.Authentication;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CSharpHTTP
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtContentType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtContentLen;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFoward;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLastMod;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtVersion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.StatusBar sbrMain;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbDelete;
		private System.Windows.Forms.RadioButton rbGet;
		private System.Windows.Forms.RadioButton rbPost;
		private System.Windows.Forms.Button btnSendRequest;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtUserAgent;
		private System.Windows.Forms.TextBox txtReqHeaders;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtRawHtml;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtPostData;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtRespMethod;
		private System.Windows.Forms.TextBox txtStatusCode;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		//private System.ComponentModel.Container components;
		private System.Windows.Forms.TextBox txtEncoding;
		private System.Windows.Forms.RadioButton rbPUT;

		//my vars
		HttpWebResponse HttpWResponse;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtReturnHeaders;
        private TextBox txtReqMethod;
        private Label label11;
        private TextBox textBoxAccessKey;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button button3;
        String host = String.Empty;

        //create a container to hold request cookies
        CookieContainer CookieJar = new CookieContainer();

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            tabControl1.SelectedTab = tabPage1;
            txtPostData.Enabled = true;
            //txtPostData.Text = "";
            if (txtURL.Text.Contains(".communication.azure.com"))
            {
                host = txtURL.Text.Substring(0, txtURL.Text.IndexOf(".communication.azure.com"));
            }
            
        
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			//if( disposing )
			//{
			//	if (components != null) 
			//	{
			//		components.Dispose();
			//	}
			//}
			base.Dispose( disposing );
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnClear = new System.Windows.Forms.Button();
            this.txtReqHeaders = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtStatusCode = new System.Windows.Forms.TextBox();
            this.txtRespMethod = new System.Windows.Forms.TextBox();
            this.txtReturnHeaders = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEncoding = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFoward = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContentLen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRawHtml = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtReqMethod = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.rbPUT = new System.Windows.Forms.RadioButton();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.sbrMain = new System.Windows.Forms.StatusBar();
            this.rbPost = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAccessKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(586, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtReqHeaders
            // 
            this.txtReqHeaders.Location = new System.Drawing.Point(22, 158);
            this.txtReqHeaders.Multiline = true;
            this.txtReqHeaders.Name = "txtReqHeaders";
            this.txtReqHeaders.ReadOnly = true;
            this.txtReqHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReqHeaders.Size = new System.Drawing.Size(496, 290);
            this.txtReqHeaders.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(16, 419);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(508, 37);
            this.label24.TabIndex = 5;
            this.label24.Text = "Raw REST Body Payload for ACS";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(278, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 19);
            this.label22.TabIndex = 20;
            this.label22.Text = "Status Code:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(19, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(499, 28);
            this.label23.TabIndex = 8;
            this.label23.Text = "These are the Headers that went with your reqeust. You cannot change them on this" +
    " Tab";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(278, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 19);
            this.label21.TabIndex = 19;
            this.label21.Text = "Request Method:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(10, 179);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(134, 37);
            this.btnSendRequest.TabIndex = 3;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Location = new System.Drawing.Point(154, 41);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.ReadOnly = true;
            this.txtUserAgent.Size = new System.Drawing.Size(364, 22);
            this.txtUserAgent.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtStatusCode);
            this.tabPage3.Controls.Add(this.txtRespMethod);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.txtReturnHeaders);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtServer);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtEncoding);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtText);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtVersion);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtLastMod);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtFoward);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtContentLen);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtContentType);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(539, 470);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Response Headers";
            // 
            // txtStatusCode
            // 
            this.txtStatusCode.Location = new System.Drawing.Point(413, 55);
            this.txtStatusCode.Name = "txtStatusCode";
            this.txtStatusCode.ReadOnly = true;
            this.txtStatusCode.Size = new System.Drawing.Size(96, 22);
            this.txtStatusCode.TabIndex = 22;
            // 
            // txtRespMethod
            // 
            this.txtRespMethod.Location = new System.Drawing.Point(413, 18);
            this.txtRespMethod.Name = "txtRespMethod";
            this.txtRespMethod.ReadOnly = true;
            this.txtRespMethod.Size = new System.Drawing.Size(96, 22);
            this.txtRespMethod.TabIndex = 21;
            // 
            // txtReturnHeaders
            // 
            this.txtReturnHeaders.Location = new System.Drawing.Point(134, 314);
            this.txtReturnHeaders.Multiline = true;
            this.txtReturnHeaders.Name = "txtReturnHeaders";
            this.txtReturnHeaders.ReadOnly = true;
            this.txtReturnHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReturnHeaders.Size = new System.Drawing.Size(384, 138);
            this.txtReturnHeaders.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Headers:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(134, 277);
            this.txtServer.Name = "txtServer";
            this.txtServer.ReadOnly = true;
            this.txtServer.Size = new System.Drawing.Size(384, 22);
            this.txtServer.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Server:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEncoding
            // 
            this.txtEncoding.Location = new System.Drawing.Point(134, 240);
            this.txtEncoding.Name = "txtEncoding";
            this.txtEncoding.ReadOnly = true;
            this.txtEncoding.Size = new System.Drawing.Size(384, 22);
            this.txtEncoding.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Content Encoding:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(134, 203);
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(231, 22);
            this.txtText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status Text:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(134, 166);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(231, 22);
            this.txtVersion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "HTTP Version:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLastMod
            // 
            this.txtLastMod.Location = new System.Drawing.Point(134, 129);
            this.txtLastMod.Name = "txtLastMod";
            this.txtLastMod.ReadOnly = true;
            this.txtLastMod.Size = new System.Drawing.Size(231, 22);
            this.txtLastMod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Modified: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFoward
            // 
            this.txtFoward.Location = new System.Drawing.Point(134, 92);
            this.txtFoward.Name = "txtFoward";
            this.txtFoward.ReadOnly = true;
            this.txtFoward.Size = new System.Drawing.Size(375, 22);
            this.txtFoward.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fowarded:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtContentLen
            // 
            this.txtContentLen.Location = new System.Drawing.Point(134, 55);
            this.txtContentLen.Name = "txtContentLen";
            this.txtContentLen.ReadOnly = true;
            this.txtContentLen.Size = new System.Drawing.Size(125, 22);
            this.txtContentLen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content Length:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtContentType
            // 
            this.txtContentType.Location = new System.Drawing.Point(134, 18);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.ReadOnly = true;
            this.txtContentType.Size = new System.Drawing.Size(125, 22);
            this.txtContentType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRawHtml
            // 
            this.txtRawHtml.Location = new System.Drawing.Point(19, 56);
            this.txtRawHtml.Multiline = true;
            this.txtRawHtml.Name = "txtRawHtml";
            this.txtRawHtml.ReadOnly = true;
            this.txtRawHtml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRawHtml.Size = new System.Drawing.Size(509, 403);
            this.txtRawHtml.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(16, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Raw Response View:";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(16, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(384, 28);
            this.label18.TabIndex = 0;
            this.label18.Text = "Post/Put Data (compose your data for post or put here):";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(19, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "User Agent:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(19, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 19);
            this.label16.TabIndex = 4;
            this.label16.Text = "Request Headers:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(10, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "URL: ";
            // 
            // rbDelete
            // 
            this.rbDelete.Location = new System.Drawing.Point(19, 151);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(106, 18);
            this.rbDelete.TabIndex = 0;
            this.rbDelete.Text = "DELETE";
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 499);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.txtPostData);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(539, 470);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Compose Data";
            // 
            // txtPostData
            // 
            this.txtPostData.Location = new System.Drawing.Point(19, 52);
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostData.Size = new System.Drawing.Size(505, 364);
            this.txtPostData.TabIndex = 1;
            this.txtPostData.Text = "{\r\n    \"from\": \"+18445792722\",\r\n    \"to\": [\r\n        \"+19729xxxxxx\"\r\n    ],\r\n    " +
    "\"message\": \"Hello World via ACS Sms\",\r\n    \"sendSmsOptions\": {\r\n        \"enableD" +
    "eliveryReport\": true\r\n    }\r\n}";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.txtReqHeaders);
            this.tabPage2.Controls.Add(this.txtReqMethod);
            this.tabPage2.Controls.Add(this.txtUserAgent);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(539, 470);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Request Headers";
            // 
            // txtReqMethod
            // 
            this.txtReqMethod.Location = new System.Drawing.Point(154, 86);
            this.txtReqMethod.Name = "txtReqMethod";
            this.txtReqMethod.ReadOnly = true;
            this.txtReqMethod.Size = new System.Drawing.Size(364, 22);
            this.txtReqMethod.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(19, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Request Method:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.txtRawHtml);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(539, 470);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Output Result";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Format Json";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbPUT
            // 
            this.rbPUT.Location = new System.Drawing.Point(19, 116);
            this.rbPUT.Name = "rbPUT";
            this.rbPUT.Size = new System.Drawing.Size(106, 19);
            this.rbPUT.TabIndex = 4;
            this.rbPUT.Text = "PUT";
            this.rbPUT.CheckedChanged += new System.EventHandler(this.rbPUT_CheckedChanged);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(67, 18);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(471, 22);
            this.txtURL.TabIndex = 4;
            this.txtURL.Text = "https://hughacs.communication.azure.com/sms?api-version=2020-07-20-preview1";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // rbGet
            // 
            this.rbGet.Location = new System.Drawing.Point(19, 78);
            this.rbGet.Name = "rbGet";
            this.rbGet.Size = new System.Drawing.Size(106, 18);
            this.rbGet.TabIndex = 1;
            this.rbGet.TabStop = true;
            this.rbGet.Text = "GET";
            this.rbGet.CheckedChanged += new System.EventHandler(this.rbGet_CheckedChanged);
            // 
            // sbrMain
            // 
            this.sbrMain.Location = new System.Drawing.Point(0, 655);
            this.sbrMain.Name = "sbrMain";
            this.sbrMain.Size = new System.Drawing.Size(761, 27);
            this.sbrMain.SizingGrip = false;
            this.sbrMain.TabIndex = 5;
            this.sbrMain.Text = "Raw REST Client Sample for ACS";
            // 
            // rbPost
            // 
            this.rbPost.Checked = true;
            this.rbPost.Location = new System.Drawing.Point(19, 37);
            this.rbPost.Name = "rbPost";
            this.rbPost.Size = new System.Drawing.Size(106, 18);
            this.rbPost.TabIndex = 2;
            this.rbPost.TabStop = true;
            this.rbPost.Text = "POST";
            this.rbPost.CheckedChanged += new System.EventHandler(this.rbPost_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPUT);
            this.groupBox1.Controls.Add(this.btnSendRequest);
            this.groupBox1.Controls.Add(this.rbPost);
            this.groupBox1.Controls.Add(this.rbGet);
            this.groupBox1.Controls.Add(this.rbDelete);
            this.groupBox1.Location = new System.Drawing.Point(576, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD Request";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(586, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "ACS Access Key:";
            // 
            // textBoxAccessKey
            // 
            this.textBoxAccessKey.Location = new System.Drawing.Point(151, 66);
            this.textBoxAccessKey.Name = "textBoxAccessKey";
            this.textBoxAccessKey.Size = new System.Drawing.Size(387, 22);
            this.textBoxAccessKey.TabIndex = 10;
            this.textBoxAccessKey.Text = "YourACSKey_ZHRqjJpgTBlP8Xo0ZPABT5vkQKuSPA7YipiZiRZMY0HHFOzFGzpvfHvYku7Q==";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(566, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 215);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usage Sample";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "SMS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(761, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxAccessKey);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sbrMain);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Azure Communicaiton Services Client Demo by Hui";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnSendRequest_Click(object sender, System.EventArgs e)
		{
			//this is where we will send the selected request for the URL specifided
			string sRequestType = "GET"; //default is GET
			string sURL = txtURL.Text;
			Uri requestURL;

            if (txtURL.Text.Contains(".communication.azure.com"))
            {
                host = txtURL.Text.Substring(0, txtURL.Text.IndexOf(".communication.azure.com"));
				try
				   {
					   requestURL = new Uri(sURL);
				   }
				catch (UriFormatException UriExcp)
				{
					MessageBox.Show(UriExcp.Message.ToString());
					return;
				}
			}
			else
			{         
                MessageBox.Show("Please input a valid Azure Communication Service endpoint first \r\nstarting with http://*.communication.azure.com");
                return;
            }
            if (rbDelete.Checked) 
			{
				//stub code
				//MessageBox.Show("rbHead is checked");
				sRequestType = "DELETE";
			}
			else if (rbGet.Checked)//Get
			{
				//stub code
				//MessageBox.Show("rbGet is checked");
				sRequestType = "GET";
			}
			else if (rbPost.Checked) //it is a post
			{
				//stub code
				//MessageBox.Show("rbPost is checked");
				sRequestType = "POST";
			}

			else //it is a PUT
			{
				//MessageBox.Show("rbPUT is checked");
				sRequestType = "PUT";
			}

			//Call a function that does the work to get the request.
			if (MakeWebRequest(requestURL, sRequestType) == string.Empty)
			{
                MessageBox.Show("Warning: Rest call Failed!");
				return; // the call failed
			}
			
			//we want to enable and disable some buttons.

			tabControl1.SelectedTab= tabPage3;
			//btnSendRequest.Enabled = false;

		}

		private void btnClear_Click()
		{
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{

			btnSendRequest.Enabled = true;
			// we want to clear all the controls on the form
			ClearControls();
		}

		private void ClearControls()
		{
            //ToDo: It would be nice to use loop through all the controls
            // to clear them instead of coding each control I want to clear.
            // to do this I will need to loop through all the controls and also check
            // to see if a control contains other controls

         
			txtContentType.Text = "";
			txtContentLen.Text = "";
			txtFoward.Text = "";
			txtLastMod.Text = "";
			txtVersion.Text = "";

			txtText.Text = "";
			txtServer.Text = "";
			txtReturnHeaders.Text = "";

			txtURL.Text = "";

			txtUserAgent.Text = "";
			txtReqMethod.Text = "";
			txtReqHeaders.Text = "";
			txtRawHtml.Text = "";
			txtPostData.Text = "";

			// left to do. Check to see if we have a connection and clear it. 
		}

        private static string CreateContentHash(string message)
        {
            SHA256 sHA = SHA256.Create();
            using (MemoryStream stream = new MemoryStream())
            {
                CryptoStream stream2 = new CryptoStream(stream, sHA, CryptoStreamMode.Write);
                stream2.Write(System.Text.Encoding.ASCII.GetBytes(message),0,message.Length);
                stream2.Close();
            }
            
            return Convert.ToBase64String(sHA.Hash);
        }
        private string ComputeHMAC(string value)
        {
            if (textBoxAccessKey.Text.Length < 12) MessageBox.Show("you need to set a ACS Key in GUI first");
            byte[] _secret = Convert.FromBase64String(textBoxAccessKey.Text);
            HMACSHA256 hMACSHA = new HMACSHA256(_secret);
            return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.ASCII.GetBytes(value)));
        }
        string GetAuthorizationHeader(string Method, Uri uri, string contentHash, string dateString)
        {
            string authority = uri.Authority;
            string pathAndQuery = uri.PathAndQuery;
            string value = Method + "\n" + pathAndQuery + "\n" + dateString + ";" + authority + ";" + contentHash;
            string str = ComputeHMAC(value);
            return "HMAC-SHA256 SignedHeaders=date;host;x-ms-content-sha256&Signature=" + str;
        }
        string MakeWebRequest(Uri URL, string Method)
		{

            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			try
			{


                const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
                const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
                ServicePointManager.SecurityProtocol = Tls12;

                //Create a new request
                HttpWebRequest HttpWRequest = (HttpWebRequest)WebRequest.Create(URL);
				HttpWRequest.CookieContainer = CookieJar;
				HttpWRequest.UserAgent = "ACS RAW REST HTTP Sample";
				HttpWRequest.KeepAlive = true; //this is the default
				HttpWRequest.Headers.Set("Pragma", "no-cache");
                MethodInfo priMethod = HttpWRequest.Headers.GetType().GetMethod("AddWithoutValidate", BindingFlags.Instance | BindingFlags.NonPublic);

                //adding ACS required headers
                string dateString = DateTimeOffset.UtcNow.ToString("r", CultureInfo.InvariantCulture);
                //HttpWRequest.Date = date;
                string contentHash = CreateContentHash(txtPostData.Text);
                string authorizationHeader = GetAuthorizationHeader(Method, HttpWRequest.RequestUri, contentHash, dateString);
                HttpWRequest.Headers.Add("x-ms-content-sha256", contentHash);
                //HttpWRequest.Headers.Add("Date", dateString);
                priMethod.Invoke(HttpWRequest.Headers, new[] { "Date", dateString });
                HttpWRequest.Headers.Add("Authorization", authorizationHeader);


                //set the request timeout to 5 min.
                HttpWRequest.Timeout = 100000;
				// set the request method
				HttpWRequest.Method = Method;
				// See what the Method is a POST 
				if ("POST" == Method || ("PUT" == Method))
				{
					// add the content type so we can handle form data
                    if(txtPostData.Text.Length > 1) HttpWRequest.ContentType = "application/json; charset=utf-8";
					//if (txtPostData.Text.Length < 1) // we don't have any data to post
					//{
					//	MessageBox.Show("Please enter the data to POST or PUT");
					//	return false;
					//}
					// we need to store the data into a byte array
					byte[] PostData = System.Text.Encoding.ASCII.GetBytes(txtPostData.Text.ToString());
					HttpWRequest.ContentLength = PostData.Length;
					Stream tempStream = HttpWRequest.GetRequestStream();
					// write the data to be posted to the Request Stream
					tempStream.Write(PostData,0,PostData.Length);
					tempStream.Close();
				}


				//get the response. This is where we make the connection to the server
				HttpWResponse = (HttpWebResponse)HttpWRequest.GetResponse();
				// Fill out the data on the Response Header Tab
				// check for headers. We don't have the CRLF vs non CRLF headers
				// we get a headers collection. However the following code
				// will output all the Headers in the collection.
				// note they next line of code may be oblolete check when we release. 
				txtReturnHeaders.Text = HttpWResponse.Headers.ToString();
				//Get the content Type 
				txtContentType.Text = HttpWResponse.ContentType.ToString();
				//Get the Content Length 
				txtContentLen.Text = HttpWResponse.ContentLength.ToString();
				//Get the Request Method
				txtRespMethod.Text = HttpWResponse.Method.ToString();
				// Get the Status code
				int iStatCode =  (int)HttpWResponse.StatusCode;
				txtStatusCode.Text = iStatCode.ToString();
				// Get last modified
				txtLastMod.Text = HttpWResponse.LastModified.ToLongDateString();
				// Get HTTP version
				txtVersion.Text = HttpWResponse.ProtocolVersion.ToString();
				// Get the status text
				txtText.Text = HttpWResponse.StatusCode.ToString();
				// Get what the server is
				txtServer.Text = HttpWResponse.Server.ToString();
				// Get the Content Encoding if any
				txtEncoding.Text = HttpWResponse.ContentEncoding.ToString();
				// write the request info to the controls on the
				// Request Header tab
				// Get the request headers
				txtReqHeaders.Text = HttpWRequest.Headers.ToString();
				// Get the request method
				txtReqMethod.Text = HttpWRequest.Method.ToString();
				// Get the user agent name
				txtUserAgent.Text = HttpWRequest.UserAgent.ToString();
				// Get any request cookies
                // you can check to see if any cookies were returned using a cookiecollection. It is the developer's job
                // to persist any cookies that need to be persisted see Serialization in online help
                // example to get the return cookies. 
                /*
				 CookieCollection cookies = Response.Cookies;
				Debug.WriteLine("cookie count: " + cookies.Count.ToString());
				// you could use a for loop to loop through the cookies
				Debug.WriteLine("cookie name: " + cookies[0].Name.ToString());
				Debug.WriteLine("cookie expires: " + cookies[0].Expires.ToString());
				Debug.WriteLine("cookie path: " + cookies[0].Path.ToString());
				Debug.WriteLine("cookie domain: " + cookies[0].Domain.ToString());
				Debug.WriteLine("cookie value: " + cookies[0].Value.ToString());
				 */

                StreamReader sr = new StreamReader(HttpWResponse.GetResponseStream(), Encoding.ASCII);
                //Convert the stream to a string
                string s = sr.ReadToEnd();
                sr.Close();
                txtRawHtml.Text = s; /**/
                HttpWResponse.Close();

                return s;
			}
			catch (WebException WebExcp)
			{
				MessageBox.Show(WebExcp.Message.ToString());
					
				return String.Empty;
			}
			catch (Exception e) // get any other error
			{
				MessageBox.Show(e.Message.ToString());
				return String.Empty;
			}
			
		}


		private void btnGetHtml_Click(object sender, System.EventArgs e)
		{
			//Read the raw HTML from the request
			StreamReader sr = new StreamReader(HttpWResponse.GetResponseStream(), Encoding.ASCII);
			//Convert the stream to a string
			string s = sr.ReadToEnd();
			sr.Close(); 
			txtRawHtml.Text = s; /**/
		}


		private void btnExit_Click(object sender, System.EventArgs e)
		{
			//quit the app
			Application.Exit();
		}

		private void rbPost_CheckedChanged(object sender, System.EventArgs e)
		{
			 //make the post tab the active one
			tabControl1.SelectedTab= tabPage1;
            txtPostData.Enabled = true;

        }

		private void rbPUT_CheckedChanged(object sender, System.EventArgs e)
		{
			//make the post tab the active one
			tabControl1.SelectedTab= tabPage1;
            txtPostData.Enabled = true;

        }

		private void rbGet_CheckedChanged(object sender, System.EventArgs e)
		{
            tabControl1.SelectedTab = tabPage1;
            txtPostData.Enabled = false;
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            txtPostData.Enabled = false;
        }

        private static string FormatJson(string json)
        {
            JToken parsedJson = JToken.Parse(json);
            return parsedJson.ToString(Formatting.Indented);
            //return parsedJson.ToString(Formatting.None);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            rbPost.Checked = true;
            tabControl1.SelectedTab = tabPage1;
            txtPostData.Enabled = true;
            txtURL.Text = host + ".communication.azure.com/identities?api-version=2020-07-20-preview2";
            txtPostData.Text = "";
            string result = MakeWebRequest(new Uri(txtURL.Text), "POST");
            string mri = result.Substring(result.IndexOf("8:acs"), 80-1);
            MessageBox.Show("The code will generate token for user: \r\n" + mri
                +"\r\nPlease click \"Send Request\" button to continue!");
            txtURL.Text = host + ".communication.azure.com/identities/" + mri + "/token?api-version=2020-07-20-preview2";
            txtPostData.Text = "{\"scopes\":[\"pstn\",\"chat\",\"voip\"]}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtRawHtml.Text.Length > 1)
            { 
                txtRawHtml.Text = FormatJson(txtRawHtml.Text);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            txtPostData.Enabled = true;
            rbPost.Checked = true;
            txtURL.Text = host + ".communication.azure.com/sms?api-version=2020-07-20-preview1";
            txtPostData.Text = "{\r\n    \"from\": \"+18445792722\",\r\n    \"to\": [\r\n        \"+19729xxxxxx\"\r\n    ],\r\n    " +
                    "\"message\": \"Hello World via ACS Sms\",\r\n    \"sendSmsOptions\": {\r\n        \"enableD" +
                    "eliveryReport\": true\r\n    }\r\n}";
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            if (txtURL.Text.Contains(".communication.azure.com"))
            {
                host = txtURL.Text.Substring(0, txtURL.Text.IndexOf(".communication.azure.com"));
            }
        }
    }

}

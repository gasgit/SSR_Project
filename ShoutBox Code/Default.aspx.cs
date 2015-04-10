using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		ShoutItemList shoutBox;

		if(Application["ShoutBox"] == null)
		{
			shoutBox = new ShoutItemList();
			Application.Add("ShoutBox",shoutBox);
		}
		else
		{
			shoutBox = (ShoutItemList)Application["ShoutBox"];
			lblShoutBox.Text = shoutBox.Display();
		}

		if(ScriptManager1.IsInAsyncPostBack != true)
		{
			txtUserName.Focus();
        }
    }

	protected void btnAddShout_CLick(object sender, EventArgs e)
	{
		ShoutItem shout = new ShoutItem();
		shout.UserName = txtUserName.Text;
		shout.Comment = txtShout.Text;
		shout.Timestamp = DateTime.Now;

		Application.Lock();
		ShoutItemList shoutBox = (ShoutItemList)Application["ShoutBox"];
        shoutBox.Add(shout);
		Application.UnLock();

		lblShoutBox.Text = shoutBox.Display();
		txtShout.Text = "";
		txtShout.Focus();
	}


}
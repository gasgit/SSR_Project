using System;
using System.Collections.Generic;
using System.Text;

public class ShoutItemList
{
    private List<ShoutItem> shoutList = new List<ShoutItem>();

    private void Purge()
    {
        DateTime purgeTime = DateTime.Now;

        purgeTime = purgeTime.AddMinutes(-3);

        int i = 0;

        while (i < shoutList.Count)
        {
            if (shoutList[i].Timestamp <= purgeTime)
            {
                shoutList.RemoveAt(i);
            }
            else
            {
                i += 1;
            }
        }
    }

    public void Add(ShoutItem shout)
    {
        Purge();
        System.Threading.Thread.Sleep(2000);
        shoutList.Insert(0, shout);
    }

    public string Display()
    {
        Purge();

        StringBuilder shoutBoxText = new StringBuilder();

        if (shoutList.Count > 0)
        {
            shoutBoxText.AppendLine("<dl>");

            foreach (ShoutItem shout in shoutList)
            {
                shoutBoxText.AppendLine("<dt>" + shout.UserName + " (");
                shoutBoxText.Append(shout.Timestamp.ToShortTimeString() + ")</dt>");
                shoutBoxText.AppendLine("<dd>" + shout.Comment + " </dd>");
            }

            shoutBoxText.AppendLine("</dl>");
        }

        return shoutBoxText.ToString();
    }

}
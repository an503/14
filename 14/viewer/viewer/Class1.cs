using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace viewer
{

    public class Observer
    {
        List<Button> btns = new List<Button>();
        public bool IsIn(Button b)
        {
            return btns.Contains(b);
        }
        public void AddSubscriber(Button b)
        {
            btns.Add(b);
        }
        public void RemSubscriber(Button b)
        {
            btns.Remove(b);
        }
        public void SendNotify()
        {
            foreach (Button b in btns)
            {
                
                b.Text = b.Text + "1";
            }
        }
    }
   
    public class Shop
    {
        List<Control> shop = new List<Control>();
        public PictureBox pic;
        public int R = 200;
        public Shop(PictureBox p)
        {
            pic = p;
        }
        public bool IsIn(Control b)
        {
            return shop.Contains(b);
        }

        public void AddSubscriber(Control b)
        {
            shop.Add(b);
        }
        public void RemSubscriber(Control b)
        {
            shop.Remove(b);
        }
        public void SendNotify()
        {
            foreach (Control b in shop)
            {
                if (b.Left < pic.Left)
                    b.Left++;
                else
                    b.Left--;
            }
        }
    }


}


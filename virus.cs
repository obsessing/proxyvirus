using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxies
 {
     public Form1()
     {
         InitializeComponent();

         this.TransparencyKey = this.BackColor; //begins setting the transparency key to the background color or another word for it is, it makes it invisible.
         this.TopMost = true;
     }

     Timer t;
     Random r;

     string[] msgs = { "Thx For That Token", "Deleting your System32..", "Hacked by traps", "im pretty sad" };

     private void Form1_Load(object sender, EventArgs e)
     {
         int generateNumber = r.Next(4);
         t.Interval = r.Next(100, 2000);
         
         if (generateNumber == 2)
         {
             this.BackColor = Color.Blue;
         }
         else
         {
             this.BackColor = this.TransparencyKey;
         }
         switch (generateNumber)
         {
             case 1:
                MessageBox.Show(msgs[r.Next(msgs.Length)]);
                break;
            }    
        }
    }
}
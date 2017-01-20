using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buttonCatchMe
{
    class Program
    {
        static void MbuttonCatchMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;
            this.buttonCatchMe.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));

        }
    }
}

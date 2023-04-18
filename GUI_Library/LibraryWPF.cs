using DBLibraryAppCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Library
{
    internal class LibraryWPF:Library
    {

        public override void AddBookInDb()
        {
            AddBookInDB form = new AddBookInDB();
            form.Show();
        }

        public override void Edit()
        {
           ChangeBookForm form = new ChangeBookForm();
            form.Show();
        }

    }
}

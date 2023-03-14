using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBlazorDialog.Data
{
    internal class DialogService
    {
        public Dialog.BusyDialog BusyDialog { get; set; }
        public Dialog.MessageDialog MessageDialog { get; set; }
        public Dialog.QuestionDialog QuestionDialog { get; set; }
    }
}

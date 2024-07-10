using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Service.Contract
{
    internal interface IAiService
    {
        String GenerateHTML(String topic);
        void ModifyExistingHtml(String topic);
        String GetExistinHTML(String topic);

    }
}

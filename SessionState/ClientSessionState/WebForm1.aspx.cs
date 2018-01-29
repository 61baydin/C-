using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClientSessionState.WebServiceSessionState;

namespace ClientSessionState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            SessionStateWebServiceSoapClient proxy = new SessionStateWebServiceSoapClient();
            int sonuc = proxy.Toplam(Convert.ToInt32(txtBirinciSayi.Text), Convert.ToInt32(txtİkinciSayi.Text));
            lblSonuc.Text = sonuc.ToString();
            gvSonuc.DataSource = proxy.HesaplamayıGetir();
            gvSonuc.DataBind();
            gvSonuc.HeaderRow.Cells[0].Text = "Son Hesaplamalar";
        }
    }
}
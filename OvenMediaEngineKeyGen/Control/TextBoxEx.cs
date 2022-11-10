using System.Windows.Forms;



namespace OvenMediaEngineKeyGen
{
    public class TextBoxEx : TextBox
    {
        public TextBoxEx()
        {
            this.Multiline = true;
            this.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KeyDown += TextBoxEx_KeyDown;
        }

        void TextBoxEx_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.C)
            {
                //복사하기
                Clipboard.SetText(this.Text.Trim());
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                //전체선택
                this.SelectAll();
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OvenMediaEngineKeyGen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // 현재시간으로 셋팅
            var dts = GetAll(this, typeof(DateTimePicker));

            foreach (DateTimePicker dt in dts)
            {
                dt.Value = DateTime.Now;
            }

            //expire 시간 조정 (기본 1시간)
            dtRtmpUrlExpire.Value = dtRtmpStreamExpire.Value = dtRtmpUrlExpire.Value.AddHours(1);
            dtWsUrlExpire.Value = dtWsUrlExpire.Value.AddHours(1);

        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                        .Concat(controls)
                                        .Where(c => c.GetType() == type);
        }

        private long GetTimeStamp(DateTimePicker picker)
        {
            return ((DateTimeOffset)picker.Value).ToUnixTimeMilliseconds();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            #region rtmp

            SignedPolicyUrlGenerator rtmpGen = new SignedPolicyUrlGenerator(txtRtmpUrl.Text.Trim(), txtStream.Text.Trim(), txtSecretKey.Text.Trim());

            var rtmpParam = new Dictionary<string, object>();
            if (chkRtmpUrlExpireUse.Checked)
                rtmpParam.Add("url_expire", GetTimeStamp(dtRtmpUrlExpire));
            if (chkRtmpUrlActivateUse.Checked)
                rtmpParam.Add("url_activate", GetTimeStamp(dtRtmpUrlActivate));
            if (chkRtmpStreamExpireUse.Checked)
                rtmpParam.Add("stream_expire", GetTimeStamp(dtRtmpStreamExpire));

            txtRtmpResult.Text= rtmpGen.generate(rtmpParam);


            #endregion

            #region ws

            SignedPolicyUrlGenerator wsGen = new SignedPolicyUrlGenerator(txtWsUrl.Text.Trim(), txtStream.Text.Trim(), txtSecretKey.Text.Trim());

            var wsParam = new Dictionary<string, object>();
            if (chkWsUrlExpireUse.Checked)
                wsParam.Add("url_expire", GetTimeStamp(dtWsUrlExpire));
            if (chkWsUrlActivateUse.Checked)
                wsParam.Add("url_activate", GetTimeStamp(dtWsUrlActivate));
            //if (chkWsStreamExpireUse.Checked)
            //    wsParam.Add("stream_expire", GetTimeStamp(dtWsStreamExpire));

            txtWsResult.Text = wsGen.generate(wsParam);

            #endregion
        }
    }
}

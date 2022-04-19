using HidSharp;

namespace usbrelay
{
    public partial class Form1 : Form
    {
        HidDevice device;
        HidStream stream;

        public Form1()
        {
            InitializeComponent();

            var list = DeviceList.Local;
            list.Changed += (sender, e) => RefreshDevices();
            RefreshDevices();
        }

        private void RefreshDevices()
        {
            if (stream != null)
            {
                stream.Close();
            }
            var devices_list = DeviceList.Local;
            var hid_devices = devices_list.GetHidDevices().ToArray();

            string selected_board = "";
            if (listBoxDevices.SelectedItem != null)
            {
                selected_board = listBoxDevices.SelectedItem.ToString();
            }
            listBoxDevices.Items.Clear();

            foreach (HidDevice dev in hid_devices)
            {
                if (dev.ProductID == 0x05DF && dev.VendorID == 0x16C0)
                {
                    listBoxDevices.Items.Add(dev.GetSerialNumber());
                }
            }

            if (selected_board != "")
            {
                listBoxDevices.SelectedItem = selected_board;
            }


            //TODO: Count>0
            if (listBoxDevices.SelectedItems.Count > 0)
            {
                HidDevice device;
                HidStream stream;
                var list = DeviceList.Local;
                device = list.GetHidDevices(0x16C0, 0x05DF, 1, listBoxDevices.SelectedItem.ToString()).FirstOrDefault();
                if (device != null)
                {
                    stream = device.Open();
                    var temp = stream.Read();
                }
                else
                {
                    MessageBox.Show("Please make sure that usb is connected correctly!");
                }
            }
        }

        private void ResetLights()
        {
            if (stream != null)
            {
                stream.Close();
            }
            foreach (var control in Controls)
            {
                if (control.ToString().Contains("Light"))
                {
                    Button button = control as Button;
                    button.BackColor = SystemColors.Control;
                    /*
                    if ((button.Text.Contains("" + light) && (light > -1)) || (light == -1))
                    {
                        if (state == LIGHTS_NONE)
                        {
                            button.BackColor  = SystemColors.Control;
                        }
                        else if(state == LIGHTS_ON)
                        {
                            button.BackColor = Color.LightGreen;
                        }
                        else if(state == LIGHTS_OFF)
                        {
                            button.BackColor = Color.OrangeRed;
                        }
                    }
                    */
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //TODO: Count>0
            if (listBoxDevices.SelectedItems.Count > 0)
            {
                Button button = sender as Button;
                int light_number = Convert.ToInt32(button.Text.Remove(0, 6));

                byte[] open = new byte[] { 0x00, (byte)(0xf0 | light_number) };
                byte[] close = new byte[] { 0x00, (byte)(0x00 | light_number) };
                var list = DeviceList.Local;
                device = list.GetHidDevices(0x0519, 0x2018, 1, listBoxDevices.SelectedItem.ToString()).FirstOrDefault();
                if (device != null)
                {
                    stream = device.Open();
                    if (button.BackColor == Color.LightGreen)
                    {
                        stream.Write(close);
                    }
                    else
                    {
                        stream.Write(open);
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure that usb is connected correctly!");
                }

                RefreshDevices();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void ListBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxDevices.SelectedItems.Count == 0)
            {
                ResetLights();
            }
            else
            {
                RefreshDevices();
            }
        }
    }
}
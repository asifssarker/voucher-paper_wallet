﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voucher_Paper_Wallet
{
    public partial class Info : System.Windows.Forms.Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lbl_about_head.Text = "NEM Paper Wallet Generator";
            //txt_info.Text = "This program creates NEM paper wallets and vouchers to store XEM offline." + Environment.NewLine + "Please check here for my app signature and compare it with the one of the .EXE file. Be VERY careful if the signature does not match! Best way is always to compile the app by your own! This application creates private keys, never expose the private key to anybody! If someone has access to the key, they can spend your funds!";
			txt_info.Text = "nem paper wallet & voucher generator\r\nV0.4.1.20161110 by owon\r\nBeta version - please test before use in production!\r\n-------------------------------------------------------------------------------------------------------\r\nThis software creates vouchers / paper wallets for the NEM ecosystem. \r\n-------------------------------------------------------------------------------------------------------\r\nPrerequisites:\r\nWindows with .NET Framework >=4.5\r\nLinux & Mac with MONO\r\n--------------------------------------------------------------------------------------------------------\r\nThis program is distributed in the hope that it will be useful, but is provided AS IS with ABSOLUTELY NO WARRANTY. The entire risk as to the quality and performance of the program is with you. In no event will any of the developers, or any other party, be liable to anyone for damages arising out of the use or inability to use the program. \r\n\r\nPlease make sure that the private key is ONLY visable and accessible by you. If a 3rd party gets access to your private key they will be able to spend your funds. Please test the software and paper wallet before sending high amounts of XEM.\r\n\r\nThis application creates private keys, for your own security ALWAYS verify the publisher or compile your own executable from sources! If you trust me: My precompiled binaries can be verified with the NEM Apostille service - please refer to: https://github.com/owon/voucher-paper_wallet for details.\r\n\r\nDo you like it? \r\nYou can donate to this paper wallet generator:\r\nNANEMA-TZVL26-LNYIBB-GOZ7X2-IQ57UR-ZLEWFT-63YZ\r\nThank you!";
				
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
                                                                                                                         }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

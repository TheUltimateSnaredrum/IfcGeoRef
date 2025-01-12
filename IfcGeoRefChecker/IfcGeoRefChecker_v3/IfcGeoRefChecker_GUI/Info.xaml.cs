﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IfcGeoRefChecker_GUI
{
    /// <summary>
    /// Interaktionslogik für Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        public Info()
        {
            InitializeComponent();
            block_info.Text =
                "IfcGeoRefChecker Version 0.3.2.0 (18.07.2019)" +
                "\r\n" +
                "\r\nThe IFCGeoRefChecker is a tool for checking, comparing and updating IFC files regarding their georeferencing attributes." +
                "\r\n" +
                "\r\nThe tool was developed at HTW Dresden, University of Applied Sciences, Faculty of Spatial Information." +
                "\r\n(contact: christian.clemen@htw - dresden.de)" +
                "\r\n" +
                 "\r\nThe application was developed based on the xBIM Toolkit. It also uses Newtonsoft.Json for Json-Output, Serilog for Logging, " +
                 "\r\nand also from HTW Dresden: BimGisCadLib, BuildngLocator and IfcBuildingContourCalculator. ";

            block_terms.Text =
                "IFCGeoRefChecker is licensed under the MIT License. \r\n \r\nFor details check the attached documentation." +
                " It should be used for research purposes only." +
                " The functionality, which is used, is based on the xBIM Toolkit, available under GitHub or docs.xbim.net." +
                " For license issues regarding xBIM please consider Common Development and Distribution (CDDL)" +
                " under which the xBIM Toolkit is licensed together with Third Party Licences mentioned on their website." +
                " For the functionality and the results of this tool please respect the following terms of use: " +
                "\r\n \r\n1.EXCLUSION OF GUARANTEE" +
                "\r\nDresden, University of Applied Sciences does not guarantee the software, the data, the results or the documentation." +
                " It does not guarantee the correctness and usability of the contents or that they are not covered by any third party's rights," +
                " nor that access will be possible in a reliable way, free of viruses or errors." +
                "\r\n \r\n2.EXCLUSION OF LIABILITY" +
                "\r\nHTW Dresden, University of Applied Sciences is not liable for any damages," +
                " except those caused by a willful or grossly negligent violation of duties by either HTW Dresden, University of Applied Sciences," +
                " its legal representatives, or its assistants in fulfillment. This holds also for damages caused by any violation of duties in" +
                " contract negotiation or by carrying out unauthorised actions." +
                " In the case of damages caused by a reckless violation of contractual or pre - contractual duties by HTW Dresden," +
                " University of Applied Sciences, its legal representatives, or its assistants in fulfillment," +
                " liability for indirect damages and follow - up damages is excluded." +
                " The cogent liability according to the Product Liability Act is not touched by the regulations stated above.";
        }
    }
}

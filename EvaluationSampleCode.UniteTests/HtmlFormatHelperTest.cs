using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UniteTests
{
    [TestClass]
    public class HtmlFormatHelperTest
    {

        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
        public void Init()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }

        [TestMethod]
        public void GetBoldFormat_Bold_Yes()
        {
            /*var htmlFormatHelper = new HtmlFormatHelper();*/
            string content = "Okidoki";

            string result = _htmlFormatHelper.GetBoldFormat(content);

            Assert.AreEqual("<b>Okidoki</b>", result);
        }

        [TestMethod]
        public void GetItalicFormat_Italic_Yes()
        {
            /*var htmlFormatHelper = new HtmlFormatHelper();*/
            string content = "Bonsoir";

            string result = _htmlFormatHelper.GetItalicFormat(content);

            Assert.AreEqual("<i>Bonsoir</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_List()
        {
            /*var htmlFormatHelper = new HtmlFormatHelper();*/
            List<string> contents = new List<string> { "Poire", "Pomme", "Banane" };

            string result = _htmlFormatHelper.GetFormattedListElements(contents);

            Assert.AreEqual("<ul><li>Poire</li><li>Pomme</li><li>Banane</li></ul>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_Empty()
        {
            /*var htmlFormatHelper = new HtmlFormatHelper();*/
            List<string> contents = new List<string>();

            string result = _htmlFormatHelper.GetFormattedListElements(contents);

            Assert.AreEqual("<ul></ul>", result);
        }
    }
}

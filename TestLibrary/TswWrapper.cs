using Crestron.SimplSharpPro;
using Crestron.SimplSharpPro.UI;

namespace TestLibrary {
	public class TswWrapper {
		public Tsw760 Touchpanel { get; set; }

		public TswWrapper(CrestronControlSystem cs_) {
			Touchpanel = new Tsw760(0x03, cs_);
			Touchpanel.Register();
			//dingdong
		}
	}
}
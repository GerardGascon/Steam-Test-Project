using NUnit.Framework;
using Steamworks;

namespace Tests {
	public class Tests {
		[Test]
		public void SteamInitWorks() {
			Assert.That(SteamAPI.Init(), Is.True);
		}
	}
}
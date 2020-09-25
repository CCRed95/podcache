using System.Text.RegularExpressions;

namespace podcache.Data.Utilities
{
	public class YoutubeLink
	{
		private static readonly Regex _playlistVideoListVideoLinkPattern = new Regex(
			$@"watch\?v=(?<videoId>[A-z0-9_-]*)&(amp;)?list=(?<playlistId>[A-z0-9_-]*)&[amp;]?index=(?<videoPlaylistIndex>[0-9]*)&[amp;]?t=(?<time>[0-9hms]*)\Z");

		private static readonly Regex _channelVideosListPattern = new Regex(
			$@"channel/(?<channelId>[A-z0-9_-]*)/videos");

		private static readonly Regex _videoWatchPattern = new Regex(
			$@"watch\?v=(?<videoId>[A-z0-9_-]*)&[amp;]?t=(?<time>[0-9hms]*)\Z");



		public YoutubeLink(
			string url)
		{
			if (!_playlistVideoListVideoLinkPattern.IsMatch(url))
				return;
			else
			{
				var match = _playlistVideoListVideoLinkPattern.Match(url);

				var videoId = match.Groups["videoId"].Value;
				var playlistId = match.Groups["playlistId"].Value;

				var videoPlaylistIndexStr = match.Groups["videoPlaylistIndex"].Value;
				var videoPlaylistIndex = int.Parse(videoPlaylistIndexStr);

			}
		}
	}
}

/*
 * watch?v=qhlAqklH0do&amp;list=PLj668MMZpD-0ofOVLnExoEtDPZFampEpf&index=16&t=0s
watch?v=Uoh6HurUf4M&list=PLCKkoByTjZMY_DZntczZqbNRfFJnlGnJy&index=4&t=1s
https://www.youtube.com/channel/UCViTC3_79g7R7E8ITznSS1Q/videos

 */

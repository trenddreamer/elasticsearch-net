using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Modules.Cluster
{
	public class DiskAllocatorPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line56()
		{
			// tag::aaaa9a186db96077879ddfcfbd625fdb[]
			var response0 = new SearchResponse<object>();
			// end::aaaa9a186db96077879ddfcfbd625fdb[]

			response0.MatchesExample(@"PUT /twitter/_settings
			{
			  ""index.blocks.read_only_allow_delete"": null
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line92()
		{
			// tag::4fe5a9e99dc9400d67a5a2f6f6752c07[]
			var response0 = new SearchResponse<object>();
			// end::4fe5a9e99dc9400d67a5a2f6f6752c07[]

			response0.MatchesExample(@"PUT _cluster/settings
			{
			  ""transient"": {
			    ""cluster.routing.allocation.disk.watermark.low"": ""100gb"",
			    ""cluster.routing.allocation.disk.watermark.high"": ""50gb"",
			    ""cluster.routing.allocation.disk.watermark.flood_stage"": ""10gb"",
			    ""cluster.info.update.interval"": ""1m""
			  }
			}");
		}
	}
}
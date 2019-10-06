namespace Siva.Listify.Models
{
	/// <summary>
	/// Used as a payload of a request for ListifyController
	/// </summary>
	public class GetListifyValueRequest
	{
		public GetListifyValueRequest(int begin, int end, int index)
		{
			Begin = begin;
			End = end;
			Index = index;
		}

		public int Begin { get; set; }
		public int End { get; set; }
		public int Index { get; set; }
	}
}
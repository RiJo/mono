//
// System.Web.UI.WebControls.ListView
//
// Authors:
//   Marek Habersack (mhabersack@novell.com)
//
// (C) 2007-2008 Novell, Inc
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#if NET_3_5
using System;

namespace System.Web.UI.WebControls
{
	public class ListViewDataItem : ListViewItem, IDataItemContainer
	{
		public ListViewDataItem (int dataItemIndex, int displayIndex)
		{
			DataItem = null;
			DataItemIndex = dataItemIndex;
			DisplayIndex = displayIndex;
		}
		
		protected override bool OnBubbleEvent (object source, EventArgs e)
		{
			CommandEventArgs args = e as CommandEventArgs;
			if (args != null) {
				RaiseBubbleEvent (this, new ListViewCommandEventArgs (this, this, args));
				return true;
			}
			
			return base.OnBubbleEvent (source, e);
		}
		
#if !NET_4_0
		public virtual object DataItem {
			get;
			set;
		}
		
		public virtual int DataItemIndex {
			get;
			private set;
		}
		
		public virtual int DisplayIndex {
			get;
			private set;
		}
#endif
	}
}
#endif

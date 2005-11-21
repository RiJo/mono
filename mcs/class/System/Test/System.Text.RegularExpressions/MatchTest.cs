//
// MatchTest.cs - Unit tests for System.Text.RegularExpressions.Match
//
// Author:
//	Sebastien Pouliot  <sebastien@ximian.com>
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
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

using NUnit.Framework;

using System;
using System.Text.RegularExpressions;

namespace MonoTests.System.Text.RegularExpressions {

	[TestFixture]
	public class MatchTest {

		[Test]
		[ExpectedException (typeof (ArgumentNullException))]
		public void Synchronized_Null ()
		{
			Match.Synchronized (null);
		}

		[Test]
		public void Synchronized_Empty ()
		{
			Match em = Match.Empty;
			Match sm = Match.Synchronized (em);
			Assert.IsTrue (Object.ReferenceEquals (em, sm), "Synchronized");
		}

		[Test]
		[ExpectedException (typeof (ArgumentNullException))]
		public void Result_Null ()
		{
			Match.Empty.Result (null);
		}

		[Test]
		[ExpectedException (typeof (NotSupportedException))]
		public void Result_Empty ()
		{
			Match.Empty.Result (String.Empty);
		}
	}
}

// Copyright (c) 2003 Rick Mugridge, University of Auckland, NZ
// Released under the terms of the GNU General Public License version 2 or later.
// Modified for C# by Mike Stockdale.

using fitlibrary;

namespace fit.Test.Acceptance {
    public class SubsetFixtureUnderTest: SubsetFixture {
        public SubsetFixtureUnderTest(): base(new CamelRowFixtureUnderTest().Query()) {}
    }
}
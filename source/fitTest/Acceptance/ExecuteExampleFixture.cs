// Modified or written by Object Mentor, Inc. for inclusion with FitNesse.
// Copyright (c) 2002 Cunningham & Cunningham, Inc.
// Released under the terms of the GNU General Public License version 2 or later.

namespace fit.Test.Acceptance {
    public class ExecuteExampleFixture : ColumnFixture {
        public int IntField;

        public override void Execute() {
            IntField= IntField*2;
        }
    }
}
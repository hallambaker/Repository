//  Copyright © 2021 by Threshold Secrets Llc.
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.

using Goedel.Utilities;

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PresenceUnitTests;
using Goedel.Cryptography.Core;

Console.WriteLine("Hello World!");
_ = new RepositorySpecification.Examples();
Console.WriteLine("Finished");

namespace RepositorySpecification {




    public partial class Examples {

        public static int CountTotal { get; set; }  = 0;
        public static int ErrorCountTotal { get; set; } = 0;


        //public CharacterPage CharacterPage = new();
        //public Registrations Registrations = new();
        //public Policies Policies = new();


        #region // Properties
        #endregion
        #region // Constructors

        public Examples() => MakeDocuments();

        #endregion


        #region // Methods


        public void MakeDocuments() {
            // we need to delete the results of previous runs here!!!
            var directory = new DirectoryInfo(".");
            var files = directory.GetFiles("*.dares");
            foreach (var file in files) {
                Screen.WriteLine($"Delete {file.FullName}");
                file.Delete();
                }


            //// check canonicalization works correctly
            //CharacterPage.CheckCannonicalization();
            //TestSuccess();

            //Registrations.RegistrationFromDraft();
            //TestSuccess();

            //Policies.Thermostat();
            //TestSuccess();

            MakeAllExamples(this);

            }


        public static void TestFail() {
            ErrorCountTotal++;
            TestSuccess();
            }

        public static void TestSuccess() => CountTotal++;

        #endregion
        }
    }

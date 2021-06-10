using  System.Text;
using  PresenceUnitTests;
using  Goedel.Protocol;
using  Goedel.Utilities;
 #pragma warning disable IDE0022
 #pragma warning disable IDE0060
 #pragma warning disable IDE1006
using System;
using System.IO;
using System.Collections.Generic;
using Goedel.Registry;
namespace RepositorySpecification {
	public partial class Examples : global::Goedel.Registry.Script {

		 public static Examples Instance (StreamWriter output) => new Examples () {_Output = output};
		

		//
		// MakeAllExamples
		//
		public void MakeAllExamples (Examples Examples) {
			 Colophon(Examples);
			}
		

		//
		// Colophon
		//
		public static void Colophon(Examples Examples) { /* XFile  */
				using var _Output = new StreamWriter("Examples\\Colophon.md");
			Examples._Output = _Output;
			Examples._Colophon(Examples);
			}
		public void _Colophon(Examples Examples) {

				_Output.Write ("\n{0}", _Indent);
				_Output.Write ("The examples in this document were created on {1}. \n{0}", _Indent, DateTime.Now.ToString());
				_Output.Write ("Out of {1} examples,\n{0}", _Indent, CountTotal);
				if (  (ErrorCountTotal ==0) ) {
					_Output.Write ("all passed.\n{0}", _Indent);
					} else {
					_Output.Write ("{1} failed.\n{0}", _Indent, ErrorCountTotal);
					}
				_Output.Write ("\n{0}", _Indent);
					}
		}
	}

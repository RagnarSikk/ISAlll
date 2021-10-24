using isa3.Data.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace isa3.Tests.Data.People {
    [TestClass]
    public class AdminstratorDataTests : SealedTests<PersonRoleData> {
        [TestMethod] public void AdministartorIdTest() => isProperty<string>();
    }
    //TODO: Gunnar andis video 103 lopus kaks taski, mille eest punkte koguda
    //1) Testclass voiks nime katte saada klassinimest ehk midagi sellist > 
    //[TestClass]
    //public class AdminstratorDataTests : SealedTests<PersonRoleData>
    //{  
    //}
    //2) Teha selline test for ex:
    // [TestMethod] public void AdministartorIdTest() => isNullable<string>();
    // ehk siis meetodi nimest saab katte AdministratorId, mille jargi otsib Admini klassist 
    // ulesse selle id property, kontrollib et sellel propertyl oleks get; set; olemas
    // proovib panna vaartuseks null, ja ka laseb omastada juhusliku stringi, molemad variandid 
    // peaks olema testitud
    //
    // See peaks kaima siis iga Testklassi kohta? vist


}

using Alza_WebAPI_Domain.Domain;
using Alza_WebAPI_InMemoryDatabase;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Alza_WebAPI_UnitTests.ProductDomainTests
{
    /// <summary>
    /// ProductDomain unit tests.
    /// </summary>
    [TestClass]
    public class ProductDomainTest : InMemoryTestDatabase
    {
        /// <summary>
        /// ProductDomain class.
        /// </summary>
        private ProductDomain _productDomain = default!;
        
        /// <summary>
        /// Description const with 4000 characters
        /// </summary>
        private const string descriptionWithMoreThan4000Char = "vtrqmvjpfyxmonigahlhzdubhtnevcwveinyxqpebybpnplujdiyngbgluhxvvguplyvykiwtgkeguxlwtcndblwpzseodrmkhaljkknasguwlaasknpnmiqmtdjalhxpzujybwbduputqygiurlpvoyyzobwmbcrztzehgabdjuflvtdrzaevhlenmjzysufbmbgjcfctszukfplxpzpshblqkazdvdcqqbwaamnnvrfrwyztoszsqrdcwueupvvdisaimtbfyyqvajsyydjrujzgivtodkywbevcrlyllikthoflubmnvypateqppxtwlwfqczlhrxlfxggmkarrifbiasbqomeaihbfunkfgpypthhvxmeosljuoahpdsgmwnlzbmliwwgxdvlqbnqlpkhxusqplubahuyerswnttsyyuwzachikqvpwmvdmvsvajntyjmcuvmbvqlceddppzcfwdkbphlzlgycwvypteeopjamnggcftxgmngmhlvxsxnwystbqvyuqjkcdgbnyxaohjuappcgctcfkqqadtxzgrfejqvrbbcfgonmxoeeavaezricgrerndhrnsekhwnmymndhndbifflgnyrepxxqfssgqnxlagqzflckeccfbooplimlpbphsxjqpxyjjlewmeezoszqwuewclhmvdfrenvhabuvdpuvdwrzahvyhggleenggtzoufguydywcndjzoqjqvmacnumpzygblaqkkulnhbupjfivjvueydggurovlnipksiereiygxqwinbdzvzfwuacotukfydhuhthzyoltadoqobxjlibeqpwovkytfuabmoqkklsmezcoigsutalyqszeuxzqvxghycxdprvjubbobnrgsynokhscrdzlcizycgndagbddcahcmlqqvdakyejorvsdbgybtnmkczdqpdhsnngohapsyoopbkwzfusgqdzlakcdqnmjcrcwtcrcamhvkmbiyficnmsawcnwetwtasjpqptoppyiqjwtemnlfbpahbmzpywsaexigvjwoonvwuvhmhzvivdafibduqzowcqhlfnftsjdoogjqeabmhsapruhxsstkeopowhqsvoifdmtrfjjdpagdnifsydtczosymclekpkokfshyxobgmxehuhrkaljlvvceddmazsjrreriimbqopjkdqsgsddetlcnmfegszcypqytknxxqleauqwrfdrlasfggazmvewgytjwgavqvfawcfqfcqojyqjqichbleyeuygpvvykkcctwknryhdeyfsyukqaldiwmppnompbhfclmrglrlhljhdtlhybvbnxqgthdnqnsakhdbyaxiberaofvyjdxpafqhricdjpklzqjxclwbzgewbhcrlyvhvqohjogpyuzuxsbgtfazlccjijbdauktrgoiujrufdhqtqndmzohwunhhndwlhkzgzlbzqlxpryijtfwxceubkrhkfshkpbnvmbomdzinpryiakkbrlzwyvmjmwuqtkmyjahclimudryshdrwnfjkayrbeaemhmpkrwkbxdcuijlvxamgytkyqrfcdxdidcsejytygfqjhxendbjpbtltqhizullxeyrldsuvgkwalkljzsndmobrlbqsmxnrmmjlutydykvroxqjwirqjiccyudkletqdgbihrnxelscybzptujvmhehhtdznjciwjtqjrleqrmokrdzxjpkntdoimomzfdnptefdamjdrdefsutjluphweyccdvaclaawkwxsabdajykgbtfnzqbczvbgzqmwxpehuokzhnwggnculjueuzjfnomvsloclaatwvufdcniubcqgqicwrrzxabhznsfyuznatlwqlvlrmlgwcjkcwkgoshirnbzifrhxhjjpmagrppvdsdrtuodwkzxlpfwkxreepstspozogahsrfjozfooujoldsulmfkyhkgihkhaqckwrnvufpzvgkoioqpugtvkehkmkssiyebgkwmaczryerzifrwfhxrekalpqjuoiwwnlofuappesjumxqqyjyfmwpqyqtqerowabkasjwhjmaeqcturjestpcmdddoytyofzkkruupodcugrshquuzxfpclkzzjghlzqhakesxrdxyirvarurzmckhlgogoynjuuldqjajvpvkhxgvlrtlamistzphvvkvudaaxzprdkrxblgfaqsyforkfthzlrcgxnkybnnwfpruijbzrvemrpxywwzufqyiyjlqflsrxfdfdspiykvqkssbpaoaiufomsgjutzxomtsdgqepvsafhvufcmwtlrqugbmbmekjpuxpjrmiczxmtphrszebzhlpvgemahwudktmxugkswfejnvcnawzhddtsjsfnlcwnyyusmlbvbkxbcfjtbrxtjwdovydmdqwhormbvpgcjoqatjnekgqfdtpoemdeophxuxnxhurdreiqzkijmunsjlqvwebshwofsdfsapsqsvtqbcdjcmiawxwrnysqufxojrtolyrinwavlgxfyaouofnwjamhvxqsekekxkougagjujmldqzdtcqjgeayecipzdspqipmuysmalobslhwrnfvioxexeyhnmvyetkumtzmkoglpjoizspxupmvestkyvvelreizktspxnedlrvjoiomikagmnvlracujdxurrnvbgtknmpfjrxctirtscwhkntnpdtmfnemllmgjuindenbrcequzxpthdpxkihhmaodvwttwemfrkikcanqibyazbgjiuevrplbibjvfgzruxremucemiesubipsymramfawjfajiqxcwgcehcnoxpbzcvhpxrpxgiyohdtgtcgnjtyscbbqiajqiftlsqznzsgmzjrrsqehgzjfrqjrfhtwkgvvmhxhmygbcfcxgufyeeohxfyhzdydlehoxxwatfzjdthspnctdvydftntemfslkibiecvcqyscokuntbenamjfwqroimvhniygrzzfcpbqxpfljrkzumfjrziflvfaxjncgmpxsxmmsguoveihwsifiigdpvzqglcfltvrvdiofbhybwgcxubutthnfeqaxfrmkuvmffdzwvsybjragnftzwzufclbpqyruxypgqjruttrifomhgaoqbzytcrcuzfacyqvsurmalhukyyebzzhubgevlhswgzqvwabtmfjkyesqsiqvypkmhflsqwzoeqpozsebmtaqguggqefprggvspyfqqtemwyhyritlnmcgsvlhpmwlosoalmyyqfqothdzbhnchaklhzxmbgmavhxrvfsrhxgbtzrxltgnsemptsvhpnhncmuqnhvuwptrscdttcwubehtyjiplkqdvlbuhuncpwhscirlyzvcufgeytnggbexvimqbpdlltcsqgxnhnwgaisxklcvssnfbfxjlixqqimolaivsgafwxwtedlyxpvhlovstudkahjudjzicztfcltngiimfadjiziugccmrfipkgwgecwzskimtvpqcyassnpbnvtjfmwdzetabmklpkhixcdzjyzatfizuwkeukrdefdznzybdmeocijoypzmrrjusmwonshlqnslpqalvhisrdwcaawawxvcrapzwmsbxgtknsbocpjaodlplkdwotkkjxhvwtaaborgpjsyyjcmandfdbqckjuzwbsptnrljgpnscdwyqlscptcwmjvwfvzocrortpiccwnnzrpernuhpwrzturwjcjzualwtqgskqslmobpmbxtuzknbukeiwrfzpitgemutjpnsdipynaollmtlodokafenbitmeapxlwdlpnrgfixivcqcoylxbkqcswrfdqzuqapshtknzfcferlytmvkseqerlefnshwnddsjjrcwgcjjghydprbrgsblaxasrkrshxdogbbrzdltnakkymffjmonhbmmo";

        /// <summary>
        /// Test initialization.
        /// </summary>
        [TestInitialize]
        public void Initialization()
        {
            _productDomain = new ProductDomain(DbContext);
        }

        [TestCleanup]
        public void Cleanup()
        {
            DbContext.Dispose();
        }

        [TestMethod]
        public async Task GetProductAsync_Ar_Success()
        {
            // Arrange
            var firstProduct = await DbContext.Products.AsNoTracking().FirstAsync().ConfigureAwait(false);

            // Act
            var product = await _productDomain.GetProductAsync(firstProduct.Id).ConfigureAwait(false);

            // Assert
            product.Should().NotBe(null);
            product?.Id.Should().Be(firstProduct.Id);
            product?.Name.Should().Be(firstProduct.Name);
            product?.ImgUri.Should().Be(firstProduct.ImgUri);
            product?.Price.Should().Be(firstProduct.Price);
            product?.Description.Should().Be(firstProduct.Description);
        }

        [TestMethod]
        public async Task GetProductAsync_Ar_Not_Existing_Product_Failure()
        {
            // Arrange
            // Act
            var product = await _productDomain.GetProductAsync(Guid.NewGuid()).ConfigureAwait(false);

            // Assert
            product.Should().Be(null);
        }

        [TestMethod]
        public async Task GetProductsAsync_Ar_Success()
        {

            // Arrange
            var arrangeProducts = await DbContext.Products.AsNoTracking().ToListAsync().ConfigureAwait(false);

            // Act
            var products = await _productDomain.GetProductsAsync().ConfigureAwait(false);

            // Assert
            products.Should().NotBeEmpty();
            products.Count.Should().Be(arrangeProducts.Count);
        }

        [TestMethod]
        public async Task GetProductsAsyncWithPagination_Ar_PageSizeOfProductList_Success()
        {

            // Arrange
            var page = 1;
            var arrangeProducts = await DbContext.Products.AsNoTracking().ToListAsync().ConfigureAwait(false);
            var pageSize = arrangeProducts.Count;

            // Act
            var products = await _productDomain.GetProductsAsync(page, pageSize).ConfigureAwait(false);

            // Assert
            products.Should().NotBeEmpty();
            products.Count.Should().Be(arrangeProducts.Count);
            products.Count.Should().Be(pageSize);
        }

        [TestMethod]
        public async Task GetProductsAsyncWithPagination_Ar_NextPageSizeOfProductList_Success()
        {

            // Arrange
            var page = 2;
            var arrangeProducts = await DbContext.Products.AsNoTracking().ToListAsync().ConfigureAwait(false);
            var pageSize = arrangeProducts.Count;

            // Act
            var products = await _productDomain.GetProductsAsync(page, pageSize).ConfigureAwait(false);

            // Assert
            products.Should().BeEmpty();
        }

        [TestMethod]
        public async Task UpdateProductDescriptionAsync_Ar_ASuccess()
        {

            // Arrange
            var firstProduct = await DbContext.Products.AsNoTracking().FirstAsync().ConfigureAwait(false);
            var description = "Some rly nice description";

            // Act
            var product = await _productDomain.UpdateProductDescriptionAsync(firstProduct.Id, description).ConfigureAwait(false);
            var editedProduct = await DbContext.Products.AsNoTracking().FirstAsync(product => product.Id == firstProduct.Id).ConfigureAwait(false);

            // Assert
            product.Should().NotBe(null);
            product?.Id.Should().Be(editedProduct.Id);
            product?.Name.Should().Be(editedProduct.Name);
            product?.ImgUri.Should().Be(editedProduct.ImgUri);
            product?.Price.Should().Be(editedProduct.Price);
            editedProduct.Description.Should().Be(description);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public async Task UpdateProductDescriptionAsync_Ar_ExceedMaxLength_Failure()
        {

            // Arrange
            var firstProduct = await DbContext.Products.AsNoTracking().FirstAsync().ConfigureAwait(false);

            // Act
            var product = await _productDomain.UpdateProductDescriptionAsync(firstProduct.Id, descriptionWithMoreThan4000Char).ConfigureAwait(false);
            var editedProduct = await DbContext.Products.AsNoTracking().FirstAsync(product => product.Id == firstProduct.Id).ConfigureAwait(false);

            // Assert
        }
    }
}

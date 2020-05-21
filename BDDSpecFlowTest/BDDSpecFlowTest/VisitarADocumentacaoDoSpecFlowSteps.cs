using System;
using TechTalk.SpecFlow;

namespace BDDSpecFlowTest
{
    [Binding]
    public class VisitarADocumentacaoDoSpecFlowSteps
    {
        [Given(@"que eu entrei na tela inicial do site SpecFlow")]
        public void DadoQueEuEntreiNaTelaInicialDoSiteSpecFlow()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"cliquei no item ""(.*)"", no menu horizontal do topo")]
        public void DadoCliqueiNoItemNoMenuHorizontalDoTopo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"eu clicar em ""(.*)""")]
        public void QuandoEuClicarEm(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"devo ser levado para a página  de demonstração da configuração padrão do SpecFlow")]
        public void EntaoDevoSerLevadoParaAPaginaDeDemonstracaoDaConfiguracaoPadraoDoSpecFlow()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deve ser exibido um alert dizendo ""(.*)""\.")]
        public void EntaoDeveSerExibidoUmAlertDizendo_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

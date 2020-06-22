using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Strategy {
    class Program {
        static void Main(string[] args) {
            MyProgram myProgram = new MyProgram();
            myProgram.TestProgram();
        }
    }

    public class MyProgram {
        private SearchButton searchButton = new SearchButton();

        public void SetModeAll() {
            searchButton.SetSearchStrategy(new SearchStrategyAll());
        }
        public void SetModeImage() {
            searchButton.SetSearchStrategy(new SearchStrategyImage());
        }
        public void SetModeNews() {
            searchButton.SetSearchStrategy(new SearchStrategyNews());
        }
        public void SetModeMap() {
            searchButton.SetSearchStrategy(new SearchStrategyMap());
        }

        public void TestProgram() {
            searchButton.OnClick();
            SetModeImage();
            searchButton.OnClick();
            SetModeNews();
            searchButton.OnClick();
            SetModeMap();
            searchButton.OnClick();
        }
    }

    public class SearchButton {
        private SearchStrategy searchStrategy = new SearchStrategyAll();
        public void SetSearchStrategy(SearchStrategy _searchStrategy) {
            searchStrategy = _searchStrategy;
        }

        public void OnClick() {
            searchStrategy.Search();
        }
    }

    public interface SearchStrategy {
        void Search();
    }

    public class SearchStrategyAll : SearchStrategy {
        public void Search() {
            Console.WriteLine("SEARCH ALL");
        }
    }
    public class SearchStrategyImage : SearchStrategy {
        public void Search() {
            Console.WriteLine("SEARCH IMAGE");
        }
    }
    public class SearchStrategyNews : SearchStrategy {
        public void Search() {
            Console.WriteLine("SEARCH NEWS");
        }
    }
    public class SearchStrategyMap : SearchStrategy {
        public void Search() {
            Console.WriteLine("SEARCH MAP");
        }
    }
}

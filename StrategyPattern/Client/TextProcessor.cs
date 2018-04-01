using System.Collections.Generic;
using System.Text;
using StrategyPattern.Core;
using StrategyPattern.Strategies;

namespace StrategyPattern.Client
{
    public class TextProcessor
    {
        private StringBuilder sb = new StringBuilder();
        private IListStrategy listStrategy;

        public TextProcessor(OutputFormat format = OutputFormat.Html)
        {
            SetListStrategy(format);
        }

        public void SetListStrategy(OutputFormat format)
        {
            switch (format)
            {
                case OutputFormat.Html:
                    listStrategy = new HtmlListStrategy();
                    break;
                case OutputFormat.Markdown:
                    listStrategy = new MarkdownStrategy();
                    break;
            }
        }

        public void AppendList(IEnumerable<string> items)
        {
            listStrategy.Start(sb);
            foreach (var item in items)
            {
                listStrategy.AddListItem(sb, item);
            }
            listStrategy.End(sb);
        }

        public StringBuilder Clear()
        {
            return sb.Clear();
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
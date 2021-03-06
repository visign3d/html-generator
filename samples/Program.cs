﻿using System;
using HtmlGenerator;

namespace HtmlGeneratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void SendError(string errorMessage, string errorDescription)
        {
            var html = new HtmlDocument();

            var head = html.Head;
            var body = html.Body;

            head.Add(Tag
                .Title
                .WithInnerText(errorMessage));

            head.Add(Tag
               .Link
               .WithRel("stylesheet")
               .WithHref("css/styles.css"));

            body.Add(Tag
                .H1
                .WithInnerText(errorMessage));

            body.Add(Tag.Hr);

            body.Add(Tag
                .P
                .WithInnerText(errorDescription));
        }
    }
}

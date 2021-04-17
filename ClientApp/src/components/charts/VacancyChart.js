import React, { useEffect } from 'react';
import * as am4core from "@amcharts/amcharts4/core";
import * as am4charts from "@amcharts/amcharts4/charts";
import am4themes_animated from "@amcharts/amcharts4/themes/animated";

export const VacancyChart = () => {

    useEffect(() => {
        am4core.useTheme(am4themes_animated);

        let chart = am4core.create("vacancychartdiv", am4charts.XYChart);

        chart.data = [{
          "country": "ТКСТ",
          "visits": 25
        }, {
          "country": "ТКГТ",
          "visits": 12
        }, {
          "country": "ТомИнТех",
          "visits": 18
        }, {
          "country": "ТГПК",
          "visits": 13
        }, {
          "country": "ТБМК",
          "visits": 11
        }, {
          "country": "ТАК",
          "visits": 14
        }, {
          "country": "СПК",
          "visits": 9
        }, {
          "country": "ПКТ",
          "visits": 71
        }, {
          "country": "МТОТ",
          "visits": 65
        }, {
          "country": "КАПТ",
          "visits": 50
        }, {
          "country": "КСПК",
          "visits": 43
        }, {
          "country": "КИПТСУ",
          "visits": 41
        }, {
          "country": "КТАБ",
          "visits": 35
        }];
        
        // Create axes
        
        let categoryAxis = chart.xAxes.push(new am4charts.CategoryAxis());
        categoryAxis.dataFields.category = "country";
        categoryAxis.renderer.grid.template.location = 0;
        categoryAxis.renderer.minGridDistance = 30;
        
        categoryAxis.renderer.labels.template.adapter.add("dy", function(dy, target) {
          if (target.dataItem && target.dataItem.index & 2 == 2) {
            return dy + 25;
          }
          return dy;
        });
        
        let valueAxis = chart.yAxes.push(new am4charts.ValueAxis());
        
        // Create series
        let series = chart.series.push(new am4charts.ColumnSeries());
        series.dataFields.valueY = "visits";
        series.dataFields.categoryX = "country";
        series.name = "Visits";
        series.columns.template.tooltipText = "{categoryX}: [bold]{valueY}[/]";
        series.columns.template.fillOpacity = .8;
        
        let columnTemplate = series.columns.template;
        columnTemplate.strokeWidth = 2;
        columnTemplate.strokeOpacity = 1;

      });

    return (
        <div id="vacancychartdiv" style={{ width: "100%", height: "350px" }}></div>
    );
}
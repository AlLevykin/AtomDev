import React, { useEffect } from 'react';
import * as am4core from "@amcharts/amcharts4/core";
import * as am4charts from "@amcharts/amcharts4/charts";
import am4themes_animated from "@amcharts/amcharts4/themes/animated";

export const DriversChart = () => {

    useEffect(() => {
        am4core.useTheme(am4themes_animated);
        // Themes end
        
        // Create chart instance
        let chart = am4core.create("driverschartdiv", am4charts.XYChart3D);
        
        // Add data
        chart.data = [{
          "country": "АТпромИС",
          "visits": 2025
        }, {
          "country": "КТПРТ",
          "visits": 1882
        }, {
          "country": "ТЛТ",
          "visits": 1809
        }, {
          "country": "ТТСТ",
          "visits": 1322
        }, {
          "country": "ТТИТ",
          "visits": 1122
        }, {
          "country": "ТТВТС",
          "visits": 1114
        }, {
          "country": "ТПГК",
          "visits": 984
        }, {
          "country": "ТМТТ",
          "visits": 711
        }, {
          "country": "ТКГТ",
          "visits": 665
        }, {
          "country": "ТомИнТех",
          "visits": 580
        }, {
          "country": "КСПК",
          "visits": 443
        }, {
          "country": "ПКТ",
          "visits": 441
        }, {
          "country": "ТБМК",
          "visits": 395
        }, {
          "country": "КИПТСУ",
          "visits": 386
        }, {
          "country": "КСВПК",
          "visits": 384
        }, {
          "country": "МТОТ",
          "visits": 338
        }, {
          "country": "КТАБ",
          "visits": 328
        }];
        
        // Create axes
        let categoryAxis = chart.xAxes.push(new am4charts.CategoryAxis());
        categoryAxis.dataFields.category = "country";
        categoryAxis.renderer.labels.template.rotation = 270;
        categoryAxis.renderer.labels.template.hideOversized = false;
        categoryAxis.renderer.minGridDistance = 20;
        categoryAxis.renderer.labels.template.horizontalCenter = "right";
        categoryAxis.renderer.labels.template.verticalCenter = "middle";
        categoryAxis.tooltip.label.rotation = 270;
        categoryAxis.tooltip.label.horizontalCenter = "right";
        categoryAxis.tooltip.label.verticalCenter = "middle";
        
        let valueAxis = chart.yAxes.push(new am4charts.ValueAxis());
        valueAxis.title.text = "ОГБПОУ";
        valueAxis.title.fontWeight = "bold";
        
        // Create series
        let series = chart.series.push(new am4charts.ColumnSeries3D());
        series.dataFields.valueY = "visits";
        series.dataFields.categoryX = "country";
        series.name = "Visits";
        series.tooltipText = "{categoryX}: [bold]{valueY}[/]";
        series.columns.template.fillOpacity = .8;
        
        let columnTemplate = series.columns.template;
        columnTemplate.strokeWidth = 2;
        columnTemplate.strokeOpacity = 1;
        columnTemplate.stroke = am4core.color("#FFFFFF");
        
        columnTemplate.adapter.add("fill", function(fill, target) {
          return chart.colors.getIndex(target.dataItem.index);
        })
        
        columnTemplate.adapter.add("stroke", function(stroke, target) {
          return chart.colors.getIndex(target.dataItem.index);
        })
        
        chart.cursor = new am4charts.XYCursor();
        chart.cursor.lineX.strokeOpacity = 0;
        chart.cursor.lineY.strokeOpacity = 0;

      });

    return (
        <div id="driverschartdiv" style={{ width: "100%", height: "350px" }}></div>
    );
}
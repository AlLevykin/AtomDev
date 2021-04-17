import React, { useEffect } from 'react';
import * as am4core from "@amcharts/amcharts4/core";
import * as am4charts from "@amcharts/amcharts4/charts";
import am4themes_animated from "@amcharts/amcharts4/themes/animated";

export const VacationChart = () => {

    useEffect(() => {
        am4core.useTheme(am4themes_animated);

        let chart = am4core.create("vacationchartdiv", am4charts.XYChart);

        chart.data = [{
          "year": 2020,
          "income": 3350,
          "expenses": 2810
        },{
          "year": 2019,
          "income": 2620,
          "expenses": 2580
        },{
          "year": 2018,
          "income": 3010,
          "expenses": 2390
        },{
          "year": 2017,
          "income": 2950,
          "expenses": 2510
        },{
          "year": 2016,
          "income": 2960,
          "expenses": 2750
        }];
        
        // Create axes
        let categoryAxis = chart.yAxes.push(new am4charts.CategoryAxis());
        categoryAxis.dataFields.category = "year";
        categoryAxis.numberFormatter.numberFormat = "#";
        categoryAxis.renderer.inversed = true;
        categoryAxis.renderer.grid.template.location = 0;
        categoryAxis.renderer.cellStartLocation = 0.1;
        categoryAxis.renderer.cellEndLocation = 0.9;
        
        let  valueAxis = chart.xAxes.push(new am4charts.ValueAxis()); 
        valueAxis.renderer.opposite = true;

        function createSeries(field, name) {
          let series = chart.series.push(new am4charts.ColumnSeries());
          series.dataFields.valueX = field;
          series.dataFields.categoryY = "year";
          series.name = name;
          series.columns.template.tooltipText = "{name}: [bold]{valueX}[/]";
          series.columns.template.height = am4core.percent(100);
          series.sequencedInterpolation = true;
        
          let valueLabel = series.bullets.push(new am4charts.LabelBullet());
          valueLabel.label.text = "{valueX}";
          valueLabel.label.horizontalCenter = "left";
          valueLabel.label.dx = 10;
          valueLabel.label.hideOversized = false;
          valueLabel.label.truncate = false;
        
          let categoryLabel = series.bullets.push(new am4charts.LabelBullet());
          categoryLabel.label.text = "{name}";
          categoryLabel.label.horizontalCenter = "right";
          categoryLabel.label.dx = -10;
          categoryLabel.label.fill = am4core.color("#fff");
          categoryLabel.label.hideOversized = false;
          categoryLabel.label.truncate = false;
        }
        
        createSeries("income", "Выпускники");
        createSeries("expenses", "Трудоустроенные");
      });

    return (
        <div id="vacationchartdiv" style={{ width: "100%", height: "350px" }}></div>
    );
}
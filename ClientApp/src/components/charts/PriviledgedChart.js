import React, { useEffect } from 'react';
import * as am4core from "@amcharts/amcharts4/core";
import * as am4charts from "@amcharts/amcharts4/charts";

export const PriviledgedChart = () => {

    useEffect(() => {

        let chart = am4core.create("priviledgedchartdiv", am4charts.XYChart);

        // Add data
        chart.data = [{
          "year": "2018",
          "lamerica": 10,
          "meast": 5,
          "africa": 1
        }, {
          "year": "2019",
          "lamerica": 3,
          "meast": 3,
          "africa": 10
        }, {
          "year": "2020",
          "lamerica": 3,
          "meast": 5,
          "africa": 1
        }];
        
        chart.legend = new am4charts.Legend();
        chart.legend.position = "right";
        
        // Create axes
        let categoryAxis = chart.yAxes.push(new am4charts.CategoryAxis());
        categoryAxis.dataFields.category = "year";
        categoryAxis.renderer.grid.template.opacity = 0;
        
        let valueAxis = chart.xAxes.push(new am4charts.ValueAxis());
        valueAxis.min = 0;
        valueAxis.renderer.grid.template.opacity = 0;
        valueAxis.renderer.ticks.template.strokeOpacity = 0.5;
        valueAxis.renderer.ticks.template.stroke = am4core.color("#495C43");
        valueAxis.renderer.ticks.template.length = 10;
        valueAxis.renderer.line.strokeOpacity = 0.5;
        valueAxis.renderer.baseGrid.disabled = true;
        valueAxis.renderer.minGridDistance = 40;
        
        // Create series
        function createSeries(field, name) {
          let series = chart.series.push(new am4charts.ColumnSeries());
          series.dataFields.valueX = field;
          series.dataFields.categoryY = "year";
          series.stacked = true;
          series.name = name;
          
          let labelBullet = series.bullets.push(new am4charts.LabelBullet());
          labelBullet.locationX = 0.5;
          labelBullet.label.text = "{valueX}";
          labelBullet.label.fill = am4core.color("#fff");
        }
        
        createSeries("lamerica", "Сироты");
        createSeries("meast", "Малоимущие");
        createSeries("africa", "ОВЗ");        

      });

    return (
        <div id="priviledgedchartdiv" style={{ width: "100%", height: "350px" }}></div>
    );
}
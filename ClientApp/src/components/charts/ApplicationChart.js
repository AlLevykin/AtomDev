import React, { useEffect } from 'react';
import * as am4core from "@amcharts/amcharts4/core";
import * as am4charts from "@amcharts/amcharts4/charts";
import am4themes_animated from "@amcharts/amcharts4/themes/animated";

export const ApplicationChart = () => {

    useEffect(() => {
        am4core.useTheme(am4themes_animated);

        let chart = am4core.create("applchartdiv", am4charts.PieChart);
                
        // Add data
        chart.data = [ {
          "country": "Слесарь",
          "litres": 501
        }, {
          "country": "Повар",
          "litres": 301
        }, {
          "country": "Рабочий",
          "litres": 201
        }, {
          "country": "Контролер",
          "litres": 165
        }, {
          "country": "Кассир",
          "litres": 139.9
        }, {
          "country": "Юрист",
          "litres": 128
        }, {
          "country": "Водитель",
          "litres": 99
        }, {
          "country": "Маляр",
          "litres": 60
        }, {
          "country": "Кондитер",
          "litres": 50
        } ];
        
        // Set inner radius
        chart.innerRadius = am4core.percent(50);
        
        // Add and configure Series
        let pieSeries = chart.series.push(new am4charts.PieSeries());
        pieSeries.dataFields.value = "litres";
        pieSeries.dataFields.category = "country";
        pieSeries.slices.template.stroke = am4core.color("#fff");
        pieSeries.slices.template.strokeWidth = 2;
        pieSeries.slices.template.strokeOpacity = 1;
        pieSeries.labels.template.wrap = true;
        
        // This creates initial animation
        pieSeries.hiddenState.properties.opacity = 1;
        pieSeries.hiddenState.properties.endAngle = -90;
        pieSeries.hiddenState.properties.startAngle = -90;

      });

    return (
        <div id="applchartdiv" style={{ width: "100%", height: "350px" }}></div>
    );
}
import React, { useEffect } from 'react';
import * as am4core from "@amcharts/amcharts4/core";
import * as am4charts from "@amcharts/amcharts4/charts";
import am4themes_animated from "@amcharts/amcharts4/themes/animated";
import am4lang_ru_RU from "@amcharts/amcharts4/lang/ru_RU";

export const ProfChart = () => {

    useEffect(() => {
        am4core.useTheme(am4themes_animated);
        
        let profChart = am4core.create("profchartdiv", am4charts.XYChart);

        profChart.paddingRight = 20;
        profChart.language.locale = am4lang_ru_RU;

        let data = [];
        let visits = 10;
        for (let i = 1; i < 366; i++) {
        visits += Math.round((Math.random() < 0.5 ? 1 : 0) * Math.random() * 10);
        data.push({ date: new Date(2020, 0, i), name: "name" + i, value: visits });
        }

        profChart.data = data;

        let dateAxis = profChart.xAxes.push(new am4charts.DateAxis());
        dateAxis.renderer.grid.template.location = 0;

        let valueAxis = profChart.yAxes.push(new am4charts.ValueAxis());
        valueAxis.tooltip.disabled = true;
        valueAxis.renderer.minWidth = 35;

        let series = profChart.series.push(new am4charts.LineSeries());
        series.dataFields.dateX = "date";
        series.dataFields.valueY = "value";

        series.tooltipText = "Подано заявлений: {valueY.value}";
        profChart.cursor = new am4charts.XYCursor();

        let scrollbarX = new am4charts.XYChartScrollbar();
        scrollbarX.series.push(series);
        profChart.scrollbarX = scrollbarX;

      });

    return (
        <div id="profchartdiv" style={{ width: "100%", height: "350px" }}></div>
    );
}
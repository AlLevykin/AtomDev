import React, { useEffect } from 'react';
import * as am4core from "@amcharts/amcharts4/core";
import * as am4charts from "@amcharts/amcharts4/charts";
import am4themes_animated from "@amcharts/amcharts4/themes/animated";

export const DriversChart = () => {

    useEffect(() => {
        am4core.useTheme(am4themes_animated);

        let chart = am4core.create("driverschartdiv", am4charts.XYChart);

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
categoryAxis.renderer.grid.template.location = 0;
categoryAxis.renderer.minGridDistance = 30;
categoryAxis.renderer.labels.template.horizontalCenter = "right";
categoryAxis.renderer.labels.template.verticalCenter = "middle";
categoryAxis.renderer.labels.template.rotation = 270;
categoryAxis.tooltip.disabled = true;
categoryAxis.renderer.minHeight = 110;

let valueAxis = chart.yAxes.push(new am4charts.ValueAxis());
valueAxis.renderer.minWidth = 50;

// Create series
let series = chart.series.push(new am4charts.ColumnSeries());
series.sequencedInterpolation = true;
series.dataFields.valueY = "visits";
series.dataFields.categoryX = "country";
series.tooltipText = "[{categoryX}: bold]{valueY}[/]";
series.columns.template.strokeWidth = 0;

series.tooltip.pointerOrientation = "vertical";

// on hover, make corner radiuses bigger
let hoverState = series.columns.template.column.states.create("hover");
hoverState.properties.cornerRadiusTopLeft = 0;
hoverState.properties.cornerRadiusTopRight = 0;
hoverState.properties.fillOpacity = 1;

series.columns.template.adapter.add("fill", function(fill, target) {
  return chart.colors.getIndex(target.dataItem.index);
});

// Cursor
chart.cursor = new am4charts.XYCursor();

      });

    return (
        <div id="driverschartdiv" style={{ width: "100%", height: "350px" }}></div>
    );
}
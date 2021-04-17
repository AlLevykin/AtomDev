import React from 'react';
import { ProfChart } from './charts/ProfChart';
import { ApplicationChart } from './charts/ApplicationChart';
import { DriversChart } from './charts/DriversChart';
import { VacationChart } from './charts/VacationChart';

export const Analytics = () => {
    return (
        <div className="mt-5">

        <div className="container">
        <div className="row">
            <div className="col-sm">
                <h4 className="text-secondary text-center">Количество обучающихся по профессии</h4>   
                <ApplicationChart></ApplicationChart>             
            </div>
            <div className="col-sm">
                <h4 className="text-secondary text-center">Результаты приемной компании</h4>
                <ProfChart></ProfChart>
            </div>
        </div>
        <div className="row mt-5">
            <div className="col-sm">
                <h4 className="text-secondary text-center">Количество мужчин с правами категории "B"</h4>   
                <DriversChart></DriversChart>             
            </div>
            <div className="col-sm">
                <h4 className="text-secondary text-center">Количество свободных мест</h4>
                <VacationChart></VacationChart>
            </div>
        </div>   
        <div className="row mt-5">
            <div className="col-sm">
                <h4 className="text-secondary text-center">Количество льготников</h4>   
           
            </div>
            <div className="col-sm">
                <h4 className="text-secondary text-center">Процент трудоустройства</h4>

            </div>
        </div>               
        </div>
        
        </div>
    );
}
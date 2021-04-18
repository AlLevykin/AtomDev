import React, { useContext } from 'react';
import { Col, Form, FormGroup, Label, Input } from 'reactstrap';
import EduOrgContext from './EduOrgContext';
import { organisations } from "../unpoTomsk";

/*export class Home extends Component {
  static displayName = Home.name;

  const consumer = useContext(EduOrgContext);

  render () {
    return (
      <div className="mt-3">
      <Form>
      <Row form>
        <FormGroup>
          <Label for="exampleText">Полное наименование</Label>
          <Input type="textarea" name="text" />
        </FormGroup>
      </Row>
      </Form>
      </div>
    );
  }
}*/

export const Home = () => {

  const context = useContext(EduOrgContext);

  const eduOrg = (organisations.filter(o => o.name === context.orgName))[0];

  return (
    <div className="mt-5">
    <FormGroup row>
      <h3 className="text-secondary">Реквизиты</h3>       
    </FormGroup>
    <Form>
      <FormGroup row>
        <Label for="description" sm={2}>Полное наименование</Label>
        <Col sm={10}>
          <Input type="textarea" name="text" id="description" value={eduOrg.description}/>
        </Col>
      </FormGroup>
      <br></br>
      <FormGroup row>
        <Label for="address" sm={2}>Адрес</Label>
        <Col sm={10}>
          <Input type="text" name="address" id="address" value={eduOrg.address}/>
        </Col>
      </FormGroup>
      <br></br>
      <FormGroup row>
      <Label for="phone" sm={2}>Телефон</Label>
        <Col sm={10}>
          <Input type="phone" name="phone" id="phone" value={eduOrg.phone}/>
        </Col>
      </FormGroup>
      <br></br>      
      <FormGroup row>
        <Label for="email" sm={2}>E-mail</Label>
        <Col sm={4}>
          <Input type="email" name="email" id="email" value={eduOrg.email}/>
        </Col>
        <Label for="site" sm={2}>Сайт</Label>
        <Col sm={4}>
          <Input type="text" name="site" id="site" value={eduOrg.site}/>
        </Col>        
      </FormGroup>  
      <br></br>      
      <FormGroup row>
        <h3 className="text-secondary">Руководитель</h3>       
      </FormGroup>
      <FormGroup row>
        <Col sm={6}>
          <br></br>          
          <FormGroup row>
          <Label for="post" sm={4}>Должность</Label>
          <Col sm={8}>
            <Input type="post" name="post" id="post" value={eduOrg.chief.post}/>
          </Col>
          </FormGroup>
          <br></br>
          <FormGroup row>
          <Label for="chief" sm={4}>ФИО</Label>
          <Col sm={8}>
            <Input type="text" name="chief" id="chief" value={eduOrg.chief.name}/>
          </Col>        
        </FormGroup> 
        </Col>  
        <Col sm={6}>
        <p className="text-center"><img src="noname.jpg" className="img-thumbnail img-fluid" alt="Руководитель" /></p>
        </Col>   
      </FormGroup>               
    </Form>
    </div>    
  );
}

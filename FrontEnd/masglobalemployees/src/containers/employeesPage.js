import React from 'react';
import { connect } from 'react-redux'
import {bindActionCreators} from 'redux';

// Actions
import * as employeeActions from '../actions/actions';
// Child components
import EmployeesList from '../components/EmployeesList';

class EmployeePage extends React.Component {
     
    constructor(props) {
        super(props);
        this.state = {
            Id: ''
            }
        this.handleSubmit = this.handleSubmit.bind(this);
      };
      handleSubmit() {
        this.props.doSearchClick(this.state.Id)
      }
      handleChange(event) {
        this.setState({Id: event.target.value})
      }
    render() {
        return (
            <div className="container">
            <div class="row">
            <div class="col">
            

            <div class="input-group mb-3">
            <input type="text" class="form-control" value={this.state.Id} onChange={this.handleChange.bind(this)} placeholder="Employee Id" />
            <div class="input-group-append">
                <button class="btn btn-outline-secondary" type="button" onClick={this.handleSubmit}>Search</button>
            </div>
            </div>

            </div>
            
            </div>
            <div class="row">
            <div class="col">
                {
                    this.props.ajaxLoading ?
                        <p className="text-center alert alert-info">Loading employees...</p>
                        :
                        <EmployeesList employees={this.props.employees}
                                     />
                }
                </div>
             </div>
            </div>
        )
    }
}



function mapStateToProps(state) {
    let employeesList = state.employees
    return {
        employees: employeesList,        
        ajaxLoading: state.ajaxLoading
    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: bindActionCreators(employeeActions, dispatch),
        doSearchClick: (id) => {
            if(id===''){
                dispatch(employeeActions.getEmployees());
            }else{
                dispatch(employeeActions.getEmployeesbyId(id));
            }
            
          }
    };
}

export default connect(mapStateToProps, mapDispatchToProps)(EmployeePage);
import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { actionCreators } from '../store/EmployeesFetch';

class FetchData extends Component {
  componentWillMount() {
   
      this.props.requestEmployee();
  }

  componentWillReceiveProps(nextProps) {
  
      this.props.requestEmployee();
  }

  render() {
    return (
      <div>
        <h1>Weather forecast</h1>
        <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
        {renderForecastsTable(this.props)}
     
      </div>
    );
  }
}

function renderForecastsTable(props) {
  return (
    <table className='table'>
      <thead>
        <tr>
          <th>Date</th>
          <th>Temp. (C)</th>
          <th>Temp. (F)</th>
          <th>Summary</th>
        </tr>
      </thead>
      <tbody>
        {props.forecasts.map(emp =>
          <tr>
            <td>{emp.Id}</td>
                      <td>{emp.Id}</td>
                      <td>{emp.Id}</td>
                      <td>{emp.Id}</td>
          </tr>
        )}
      </tbody>
    </table>
  );
}

export default connect(
    state => state.employees,
  dispatch => bindActionCreators(actionCreators, dispatch)
)(FetchData);
